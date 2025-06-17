import React, { useState, useEffect } from 'react';
import { useAuth } from '../context/AuthContext';

interface Parcel {
  id: string;
  waybillNumber: string;
  destination: string;
  status: string;
  sender: string;
  receiver: string;
  weight: number;
}

interface Dispatch {
  id: string;
  sourceBranch: string;
  vehicleNumber: string;
  driver: string;
  parcelIds: string[];
  dispatchTime: string;
  status: string;
  parcels?: Parcel[];
}

interface DispatchNote {
  dispatchId: string;
  sourceBranch: string;
  vehicleNumber: string;
  driver: string;
  dispatchTime: string;
  parcels: Parcel[];
}

const Dispatch: React.FC = () => {
  const { token, user } = useAuth();
  const [parcels, setParcels] = useState<Parcel[]>([]);
  const [dispatches, setDispatches] = useState<Dispatch[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [selectedParcelIds, setSelectedParcelIds] = useState<string[]>([]);
  const [vehicleNumber, setVehicleNumber] = useState('');
  const [driver, setDriver] = useState('');
  const [generatingNote, setGeneratingNote] = useState<string | null>(null);

  useEffect(() => {
    if (!user) return;
    const fetchData = async () => {
      try {
        // Fetch pending parcels
        const parcelsResponse = await fetch('http://localhost:5000/api/parcels', {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        });

        if (!parcelsResponse.ok) {
          throw new Error('Failed to fetch parcels');
        }

        const parcelsData = await parcelsResponse.json();
        setParcels(parcelsData.filter((p: Parcel) => p.status === 'pending'));

        // Fetch existing dispatches
        const dispatchesResponse = await fetch(`http://localhost:5000/api/dispatch/branch/${user.branch}`, {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        });

        if (!dispatchesResponse.ok) {
          throw new Error('Failed to fetch dispatches');
        }

        const dispatchesData = await dispatchesResponse.json();
        setDispatches(dispatchesData);
      } catch (err) {
        setError(err instanceof Error ? err.message : 'An error occurred');
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [token, user?.branch]);

  const handleCreateDispatch = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!user) return;
    if (selectedParcelIds.length === 0) {
      setError('Please select at least one parcel');
      return;
    }

    try {
      // First update parcel statuses
      const statusResponse = await fetch('http://localhost:5000/api/parcels/batch/status', {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json',
          Authorization: `Bearer ${token}`,
        },
        body: JSON.stringify({
          parcelIds: selectedParcelIds,
          status: 'in_transit'
        }),
      });

      if (!statusResponse.ok) {
        throw new Error('Failed to update parcel statuses');
      }

      // Then create the dispatch
      const dispatchResponse = await fetch('http://localhost:5000/api/dispatch', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          Authorization: `Bearer ${token}`,
        },
        body: JSON.stringify({
          parcelIds: selectedParcelIds,
          vehicleNumber,
          driver,
          sourceBranch: user.branch
        }),
      });

      if (!dispatchResponse.ok) {
        const errorData = await dispatchResponse.json();
        throw new Error(errorData.message || 'Failed to create dispatch');
      }

      const newDispatch = await dispatchResponse.json();
      setDispatches([...dispatches, newDispatch]);
      setSelectedParcelIds([]);
      setVehicleNumber('');
      setDriver('');
      setError(null);

      // Refresh parcels list
      const updatedParcelsResponse = await fetch('http://localhost:5000/api/parcels', {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      const updatedParcelsData = await updatedParcelsResponse.json();
      setParcels(updatedParcelsData.filter((p: Parcel) => p.status === 'pending'));
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to create dispatch');
    }
  };

  const handleGenerateNote = async (dispatchId: string) => {
    try {
      setGeneratingNote(dispatchId);
      const response = await fetch(`http://localhost:5000/api/dispatch/${dispatchId}/note`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      if (!response.ok) {
        throw new Error('Failed to generate dispatch note');
      }

      const note: DispatchNote = await response.json();
      
      // Create a new window for printing
      const printWindow = window.open('', '_blank');
      if (printWindow) {
        printWindow.document.write(`
          <html>
            <head>
              <title>Dispatch Note</title>
              <style>
                body { font-family: Arial, sans-serif; padding: 20px; }
                .header { text-align: center; margin-bottom: 20px; }
                .info { margin-bottom: 20px; }
                table { width: 100%; border-collapse: collapse; }
                th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }
                th { background-color: #f5f5f5; }
              </style>
            </head>
            <body>
              <div class="header">
                <h1>Dispatch Note</h1>
              </div>
              <div class="info">
                <p><strong>Source Branch:</strong> ${note.sourceBranch}</p>
                <p><strong>Vehicle Number:</strong> ${note.vehicleNumber}</p>
                <p><strong>Driver:</strong> ${note.driver}</p>
                <p><strong>Dispatch Time:</strong> ${new Date(note.dispatchTime).toLocaleString()}</p>
              </div>
              <table>
                <thead>
                  <tr>
                    <th>Waybill Number</th>
                    <th>Sender</th>
                    <th>Receiver</th>
                    <th>Destination</th>
                    <th>Weight</th>
                  </tr>
                </thead>
                <tbody>
                  ${note.parcels.map(parcel => `
                    <tr>
                      <td>${parcel.waybillNumber}</td>
                      <td>${parcel.sender}</td>
                      <td>${parcel.receiver}</td>
                      <td>${parcel.destination}</td>
                      <td>${parcel.weight} kg</td>
                    </tr>
                  `).join('')}
                </tbody>
              </table>
            </body>
          </html>
        `);
        printWindow.document.close();
        printWindow.print();
      }
    } catch (err) {
      setError(err instanceof Error ? err.message : 'Failed to generate dispatch note');
    } finally {
      setGeneratingNote(null);
    }
  };

  if (loading) {
    return (
      <div className="flex justify-center items-center h-screen">
        <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-500"></div>
      </div>
    );
  }

  return (
    <div className="p-4">
      <h1 className="text-2xl font-bold mb-4">Dispatch Management</h1>
      
      {error && (
        <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative mb-4" role="alert">
          <strong className="font-bold">Error!</strong>
          <span className="block sm:inline"> {error}</span>
        </div>
      )}

      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
        {/* Create Dispatch Form */}
        <div className="bg-white p-4 rounded-lg shadow">
          <h2 className="text-xl font-semibold mb-4">Create New Dispatch</h2>
          <form onSubmit={handleCreateDispatch}>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2">
                Vehicle Number
              </label>
              <input
                type="text"
                value={vehicleNumber}
                onChange={(e) => setVehicleNumber(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                required
              />
            </div>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2">
                Driver Name
              </label>
              <input
                type="text"
                value={driver}
                onChange={(e) => setDriver(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                required
              />
            </div>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2">
                Select Parcels
              </label>
              <div className="max-h-60 overflow-y-auto border rounded">
                {parcels.map((parcel) => (
                  <div key={parcel.id} className="p-2 hover:bg-gray-100">
                    <label className="flex items-center">
                      <input
                        type="checkbox"
                        checked={selectedParcelIds.includes(parcel.id)}
                        onChange={(e) => {
                          if (e.target.checked) {
                            setSelectedParcelIds([...selectedParcelIds, parcel.id]);
                          } else {
                            setSelectedParcelIds(selectedParcelIds.filter(id => id !== parcel.id));
                          }
                        }}
                        className="mr-2"
                      />
                      <span>
                        {parcel.waybillNumber} - {parcel.destination} ({parcel.weight} kg)
                      </span>
                    </label>
                  </div>
                ))}
              </div>
            </div>
            <button
              type="submit"
              className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
            >
              Create Dispatch
            </button>
          </form>
        </div>

        {/* Active Dispatches */}
        <div className="bg-white p-4 rounded-lg shadow">
          <h2 className="text-xl font-semibold mb-4">Active Dispatches</h2>
          <div className="overflow-x-auto">
            <table className="min-w-full">
              <thead>
                <tr className="bg-gray-100">
                  <th className="px-4 py-2 text-left">Vehicle</th>
                  <th className="px-4 py-2 text-left">Driver</th>
                  <th className="px-4 py-2 text-left">Parcels</th>
                  <th className="px-4 py-2 text-left">Status</th>
                  <th className="px-4 py-2 text-left">Time</th>
                  <th className="px-4 py-2 text-left">Actions</th>
                </tr>
              </thead>
              <tbody>
                {dispatches.map((dispatch) => (
                  <tr key={dispatch.id} className="border-b">
                    <td className="px-4 py-2">{dispatch.vehicleNumber}</td>
                    <td className="px-4 py-2">{dispatch.driver}</td>
                    <td className="px-4 py-2">{dispatch.parcelIds.length}</td>
                    <td className="px-4 py-2">
                      <span className={`px-2 py-1 rounded-full text-xs ${
                        dispatch.status === 'in_transit' ? 'bg-blue-100 text-blue-800' : 'bg-gray-100'
                      }`}>
                        {dispatch.status}
                      </span>
                    </td>
                    <td className="px-4 py-2">
                      {new Date(dispatch.dispatchTime).toLocaleString()}
                    </td>
                    <td className="px-4 py-2">
                      <button
                        onClick={() => handleGenerateNote(dispatch.id)}
                        disabled={generatingNote === dispatch.id}
                        className={`text-blue-500 hover:text-blue-700 ${
                          generatingNote === dispatch.id ? 'opacity-50 cursor-not-allowed' : ''
                        }`}
                      >
                        {generatingNote === dispatch.id ? 'Generating...' : 'Print Note'}
                      </button>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Dispatch; 
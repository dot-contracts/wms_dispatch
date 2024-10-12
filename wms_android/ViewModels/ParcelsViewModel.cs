using System;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using wms_android.data.Models;
using wms_android.data.Services;
using System.Threading.Tasks;
using wms_android.Views;
using wms_android.data.Interfaces;
using System.Diagnostics;

namespace wms_android.ViewModels
{
    public class ParcelsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IParcelService _parcelService; // Injected service
        private string _waybillNumber;
        //public string WaybillNumber { get; set; } // Shared across parcels for a Waybill
        public string _sender { get; set; }
        public string _receiver { get; set; }
        public object CurrentWaybill { get; private set; }
        private Parcel _currentParcel;

        public string WaybillNumber
        {
            get => _waybillNumber;
            set
            {
                if (_waybillNumber != value)
                {
                    _waybillNumber = value;
                    OnPropertyChanged(nameof(WaybillNumber));
                }
            }
        }

        public string Sender
        {
            get => _sender;
            set
            {
                if (_sender != value)
                {
                    _sender = value;
                    OnPropertyChanged(nameof(Sender));
                }
            }
        }
        public string Receiver
        {
            get => _receiver;
            set
            {
                if (_receiver != value)
                {
                    _receiver = value;
                    OnPropertyChanged(nameof(Receiver));
                }
            }
        }

        public Parcel CurrentParcel
        {
            get => _currentParcel;
            set
            {
                if (_currentParcel != value)
                {
                    _currentParcel = value;
                    OnPropertyChanged(nameof(CurrentParcel));
                }
            }
        }

        // Properties
        private string _moduleName = "Parcels";
        public string ModuleName
        {
            get => _moduleName;
            set
            {
                if (_moduleName != value)
                {
                    _moduleName = value;
                    OnPropertyChanged(nameof(ModuleName));
                }
            }
        }

        private decimal _totalAmount;
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                OnPropertyChanged(nameof(TotalAmount));
            }
        }

        private Parcel _parcel;
        public Parcel Parcel
        {
            get => _parcel;
            set
            {
                _parcel = value;
                OnPropertyChanged(nameof(Parcel));
            }
        }

        public ObservableCollection<string> Destinations { get; } = new ObservableCollection<string>
    {
        "Eldoret", "Kisumu", "Nakuru", "Nairobi", "Kakamega", "Kericho", "Kitale"
    };

        public ObservableCollection<string> PaymentMethods { get; } = new ObservableCollection<string>
    {
        "COD", "Paid", "Contract"
    };

        public ObservableCollection<Parcel> Parcels { get; set; } = new ObservableCollection<Parcel>();
        public ObservableCollection<Parcel> ParcelsInWaybill { get; set; } = new ObservableCollection<Parcel>();
        public ObservableCollection<string> WaybillNumbers { get; set; } = new ObservableCollection<string>();



        // Commands
        public ICommand ViewParcelsCommand { get; }
        public ICommand DoneCommand { get; }
        public ICommand AddParcelCommand { get; }
        public ICommand PrintReceiptCommand { get; }
        public ICommand ValidateParcelCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand CartCommand { get; }
        public ICommand SearchParcelCommand { get; }


        // Default constructor for XAML instantiation
        public ParcelsViewModel(IParcelService parcelService)
        {
            _parcelService = parcelService;

            // Generate the waybill number using the service
            //_waybillNumber = _parcelService.GenerateWaybillNumber();

            CurrentParcel = new Parcel
            {
                //WaybillNumber = _waybillNumber,
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
            Parcels = new ObservableCollection<Parcel>();


            // Initialize commands
            ViewParcelsCommand = new Command(OnViewParcels);
            DoneCommand = new Command(async () =>
            {
                if (await ValidateParcelAsync())
                {
                    await OnDone();
                }
            });
            CartCommand = new Command(() => OnCartDone());  // Explicitly calling the method in a lambda
            AddParcelCommand = new Command(OnAddParcel);
            PrintReceiptCommand = new Command(OnPrintReceipt);
            ValidateParcelCommand = new Command(async () => await ValidateParcelAsync());
            BackCommand = new Command(async () => await BackToParcels());
            //SearchParcelCommand = new Command(async () =>
            //{
            //    string waybillNumber = WaybillEntry?.Text; // Get the Waybill number from the entry control

            //    if (!string.IsNullOrEmpty(waybillNumber))
            //    {
            //        await SearchParcelByWaybill(waybillNumber); // Pass the waybill number to the method
            //    }
            //    else
            //    {
            //        // Handle the case where the waybill number is empty
            //        await Application.Current.MainPage.DisplayAlert("Error", "Waybill number cannot be empty", "OK");
            //    }
            //});
        }

        

        // Constructor for dependency injection
        //public ParcelsViewModel(IParcelService iparcelService) : this()
        //{
        //    _iparcelService = iparcelService;
        //}

        private async Task<bool> ValidateParcelAsync()
        {
            if (string.IsNullOrWhiteSpace(CurrentParcel.Sender) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Receiver) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Destination) ||
                string.IsNullOrWhiteSpace(CurrentParcel.PaymentMethods) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Amount.ToString()) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Quantity.ToString()))
            {
                
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Please fill in all required fields.", "OK");
                return !string.IsNullOrEmpty(CurrentParcel.WaybillNumber) && CurrentParcel.TotalAmount > 0;
            }
            return true;
        }


        private async Task OnDone()
        {
            if (CurrentParcel == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No parcel data to save", "OK");
                return;
            }

            if (_parcelService == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Parcel service is not initialized.", "OK");
                return;
            }
            try
            {
                // Ensure DispatchedAt is UTC before saving
                if (CurrentParcel.DispatchedAt.HasValue && CurrentParcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.DispatchedAt = CurrentParcel.DispatchedAt.Value.ToUniversalTime();
                }

                // Save the current parcel to the database
                await _parcelService.CreateParcelAsync(CurrentParcel);

                // Finalize the waybill, etc.
                await _parcelService.FinalizeWaybillAsync();

                // Create a new instance of ReceiptViewModel with the current parcel
                var receiptViewModel = new ReceiptViewModel(_parcelService)
                {
                    Parcel = CurrentParcel
                };

                // Navigate to the ReceiptView and pass the receiptViewModel
                var receiptView = new ReceiptView(receiptViewModel);
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);

                // Reset the form after the user confirms success
                ResetParcel();
            }
            catch (DbUpdateException dbEx)
            {
                // Log the full exception details
                Debug.WriteLine($"DbUpdateException: {dbEx.Message}");
                
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {ex.Message}", "OK");
            }

        }

        public async Task AddParcelToCart(Parcel newParcel)
        {
            // Check if there is an active waybill, create a new one if not.
            if (CurrentWaybill == null)
            {
                CurrentWaybill = await _parcelService.GenerateWaybillNumberAsync();
                // Assign the current waybill number to the new parcel
                newParcel.WaybillNumber = (string)CurrentWaybill;
            }

            

            // Set Sender and Receiver details
            Sender = newParcel.Sender;
            Receiver = newParcel.Receiver;

            // Set other parcel details
            newParcel.CreatedAt = DateTime.UtcNow;
            newParcel.Status = ParcelStatus.Pending;

            // Add parcel to the cart for the current waybill
            ParcelsInWaybill.Add(newParcel);

            // Debugging log (optional)
            Debug.WriteLine($"Parcel added: {newParcel.WaybillNumber}, {newParcel.CreatedAt}");

            // Update UI list (e.g., ObservableCollection)
            OnPropertyChanged(nameof(ParcelsInWaybill));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(Sender));
            OnPropertyChanged(nameof(Receiver));

            // Optionally show confirmation message
            await Application.Current.MainPage.DisplayAlert("Success", "Parcel added to the current waybill.", "OK");
        }

        private async void OnCartDone()
        {
            if (ParcelsInWaybill == null || !ParcelsInWaybill.Any())
            {
                await Application.Current.MainPage.DisplayAlert("Error", "No parcels in the cart to save.", "OK");
                return;
            }

            if (_parcelService == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Parcel service is not initialized.", "OK");
                return;
            }

            try
            {
                // Check if the waybill number is generated, if not, generate it
                if (string.IsNullOrEmpty(WaybillNumber))
                {
                    WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                }

                // Assign the waybill number to each parcel in the cart
                foreach (var parcel in ParcelsInWaybill)
                {
                    parcel.WaybillNumber = WaybillNumber;

                    // Ensure DispatchedAt is UTC before saving
                    if (parcel.DispatchedAt.HasValue && parcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                    {
                        parcel.DispatchedAt = parcel.DispatchedAt.Value.ToUniversalTime();
                    }
                }

                // Save all parcels in the cart to the database in a single operation
                await _parcelService.CreateCartParcels(ParcelsInWaybill.ToList());

                // Finalize the waybill after all parcels are saved
                await _parcelService.FinalizeWaybillAsync();

                // Clear the current waybill and reset the form
                CurrentWaybill = null;
                ResetCart();


                // Notify the user of success
                await Application.Current.MainPage.DisplayAlert("Success", "All parcels in the waybill have been saved.", "OK");

                // Navigate to ReceiptView and pass the cart data
                await Shell.Current.GoToAsync("ReceiptView", new Dictionary<string, object>
                    {
                        { "Parcels", ParcelsInWaybill.ToList() }, // Passing the list of parcels
                        { "WaybillNumber", WaybillNumber }, // Passing the current waybill number
                        { "TotalAmount", ParcelsInWaybill.Sum(p => p.Amount) }, // Passing the total amount for all parcels
                        { "PaymentMethod", PaymentMethods } // Passing the selected payment method if applicable
                    });

                // Update UI (refresh cart list)
                OnPropertyChanged(nameof(WaybillNumber));
                OnPropertyChanged(nameof(ParcelsInWaybill));

                // Navigate back to root (ParcelView)
                //await Application.Current.MainPage.Navigation.PopToRootAsync();
                // Create a new instance of ReceiptViewModel with the current parcel
                var receiptViewModel = new ReceiptViewModel(_parcelService)
                {
                    Parcel = CurrentParcel
                };
                var receiptCartView = new ReceiptCartView(receiptViewModel);
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptCartView);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcels: {ex.Message}", "OK");
            }
        }

        private void OnPrintReceipt()
        {
            try
            {
                if (!ValidateParcelAsync().Result)
                {
                    return; // Exit if validation fails
                }

                // Implement SDK printing logic here

                // Simulate successful printing and show alert
                Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Print error: {ex.Message}");
                Application.Current.MainPage.DisplayAlert("Error", "Failed to print receipt.", "OK");
            }
        }


        public void ResetParcel()
        {
            // Reset the parcel data for ParcelView
            CurrentParcel = new Parcel
            {
                //WaybillNumber = _waybillNumber,
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
        }

        public void ResetCart()
        {
            // Clear the parcels in the current waybill
            ParcelsInWaybill.Clear();

            // Reset the current waybill number and parcel data
            CurrentWaybill = null;

            // Optionally reset any other UI-bound properties like Sender, Receiver, and WaybillNumber
            WaybillNumber = string.Empty;
            Sender = string.Empty;
            Receiver = string.Empty;

            // Also, reset the current parcel for the next input
            ResetParcel();

            // Notify the UI that the cart has been reset
            OnPropertyChanged(nameof(ParcelsInWaybill));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(Sender));
            OnPropertyChanged(nameof(Receiver));
        }



        private async void OnViewParcels()
        {
            var viewParcelsPage = new ListParcelsView(this); // Pass the current ViewModel
            await Application.Current.MainPage.Navigation.PushAsync(viewParcelsPage);
        }

        private async Task BackToParcels()
        {
            await Application.Current.MainPage.Navigation.PopAsync(); // Navigate back to the ParcelView
        }

        private async void OnAddParcel()
        {
            if (await ValidateParcelAsync()) // Validate current parcel data
            {
                // Add the parcel to the cart, linking it to the waybill
                await AddParcelToCart(CurrentParcel);

                // Reset for next parcel input but keep the waybill number
                ResetAddParcel();

                // Update the total amount for all parcels in this waybill
                UpdateCartTotalAmount();

                await Application.Current.MainPage.DisplayAlert("Success", "Parcel added to the cart.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Please fill in all required fields.", "OK");
            }
        }


        private void UpdateTotalAmount()
        {
            TotalAmount = Parcels.Sum(p => p.Amount); // Sum only the Amount, without considering the Quantity
            OnPropertyChanged(nameof(TotalAmount));  // Notify the UI to update
        }


        private void UpdateCartTotalAmount()
        {
            TotalAmount = ParcelsInWaybill.Sum(parcel => parcel.Amount); // Calculate the total amount of all parcels
            OnPropertyChanged(nameof(TotalAmount));  // Notify UI to update
        }


        public void ResetAddParcel()
        {
            // Preserve the Sender, Receiver details and WaybillNumber
            var sender = CurrentParcel.Sender;
            var senderTelephone = CurrentParcel.SenderTelephone;
            var receiver = CurrentParcel.Receiver;
            var receiverTelephone = CurrentParcel.ReceiverTelephone;
            var waybillNumber = CurrentParcel.WaybillNumber;

            // Reset the other fields for the next parcel
            CurrentParcel = new Parcel
            {
                Sender = sender,
                SenderTelephone = senderTelephone,
                Receiver = receiver,
                ReceiverTelephone = receiverTelephone,
                WaybillNumber = waybillNumber, // Keep the same waybill number
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
        }

        



        //private bool IsParcelValid(Parcel parcel)
        //{
        //    // Add your validation logic here
        //    return !string.IsNullOrEmpty(parcel.WaybillNumber) && parcel.TotalAmount > 0;
        //}

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

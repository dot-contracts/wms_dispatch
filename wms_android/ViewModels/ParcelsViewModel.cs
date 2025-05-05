using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Microsoft.EntityFrameworkCore;
using wms_android.shared.Models;
using wms_android.data.Services;
using wms_android.Views;
using wms_android.shared.Interfaces;
using wms_android.Services;
using wms_android.Utils;

namespace wms_android.ViewModels
{
    public class ParcelsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IParcelService _parcelService;
        private readonly ISmsService _smsService;
        private readonly LoadingService _loadingService = LoadingService.Instance;
        private string _waybillNumber;
        public string _sender { get; set; }
        public string _receiver { get; set; }
        public string _senderTelephone { get; set; }
        public string _receiveTelephone { get; set; }
        public object CurrentWaybill { get; private set; }
        public bool IsReturningToView { get; set; } = false;
        private Parcel _currentParcel;

        private int? _currentUserId;
        public int? CurrentUserId 
        { 
            get => _currentUserId; 
            set
            {
                _currentUserId = value;
                OnPropertyChanged(nameof(CurrentUserId));
            }
        }

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
        public string SenderTelephone
        {
            get => _senderTelephone;
            set
            {
                if (_senderTelephone != value)
                {
                    _senderTelephone = value;
                    OnPropertyChanged(nameof(SenderTelephone));
                }
            }
        }
        public string ReceiverTelephone
        {
            get => _receiveTelephone;
            set
            {
                if (_receiveTelephone != value)
                {
                    _receiveTelephone = value;
                    OnPropertyChanged(nameof(ReceiverTelephone));
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
        "Eldoret", "Kapsabet", "Kakamega", "Kericho", "Kisumu", "Kitale", "Mombasa", "Nairobi", "Nakuru"
    };

        public ObservableCollection<string> PaymentMethods { get; } = new ObservableCollection<string>
    {
        "COD", "Paid", "Contract"
    };

        public ObservableCollection<Parcel> Parcels { get; set; } = new ObservableCollection<Parcel>();
        public ObservableCollection<Parcel> ParcelsInWaybill { get; set; } = new ObservableCollection<Parcel>();
        public ObservableCollection<string> WaybillNumbers { get; set; } = new ObservableCollection<string>();

        public ICommand ViewParcelsCommand { get; }
        public ICommand DoneCommand { get; }
        public ICommand AddParcelCommand { get; }
        public ICommand PrintReceiptCommand { get; }
        public ICommand ValidateParcelCommand { get; }
        public ICommand BackCommand { get; }
        public ICommand CartCommand { get; }
        public ICommand SearchParcelCommand { get; }
        public ICommand DeleteParcelCommand { get; }
        public ICommand EditParcelCommand { get; }
        public ICommand PrinterDiagnosticCommand { get; }

        public ParcelsViewModel(IParcelService parcelService, ISmsService smsService)
        {
            _parcelService = parcelService;
            _smsService = smsService;

            CurrentParcel = new Parcel
            {
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
            Parcels = new ObservableCollection<Parcel>();

            if (Preferences.ContainsKey("CurrentUserId"))
            {
                CurrentUserId = Preferences.Get("CurrentUserId", 0);
                if (CurrentUserId == 0) CurrentUserId = null;
            }

            ViewParcelsCommand = new Command(OnViewParcels);
            DoneCommand = new Command(async () =>
            {
                if (await ValidateParcelAsync())
                {
                    await OnDone();
                }
            });
            CartCommand = new Command(() => OnCartDone());
            AddParcelCommand = new Command(OnAddParcel);
            PrintReceiptCommand = new Command(OnPrintReceipt);
            ValidateParcelCommand = new Command(async () => await ValidateParcelAsync());
            BackCommand = new Command(async () => await BackToParcels());
            DeleteParcelCommand = new RelayCommand<Parcel>(OnDeleteParcel);
            EditParcelCommand = new RelayCommand<Parcel>(OnEditParcel);
            PrinterDiagnosticCommand = new Command(async () => await RunPrinterDiagnostics());
        }

        private async Task<bool> ValidateParcelAsync()
        {
            // 1. Validate required string fields
            if (string.IsNullOrWhiteSpace(CurrentParcel.Sender) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Receiver) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Destination) ||
                string.IsNullOrWhiteSpace(CurrentParcel.PaymentMethods) ||
                string.IsNullOrWhiteSpace(CurrentParcel.Description)) // Assuming Description is also required
            {
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Please fill in Sender, Receiver, Destination, Payment Method, and Description.", "OK");
                return false;
            }

            // 2. Validate numeric fields: EITHER Amount OR (Rate AND Quantity) must be valid
            bool isAmountValid = CurrentParcel.Amount.HasValue && CurrentParcel.Amount.Value > 0;
            bool isRateValid = CurrentParcel.Rate.HasValue && CurrentParcel.Rate.Value > 0;
            bool isQuantityValid = CurrentParcel.Quantity.HasValue && CurrentParcel.Quantity.Value > 0;

            if (!isAmountValid && !(isRateValid && isQuantityValid))
            {
                // Neither Amount is valid, NOR is the combination of Rate and Quantity valid.
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Please provide either a valid Amount OR both valid Rate and Quantity.", "OK");
                return false;
            }

            // 3. Validate phone numbers
            if (!IsValidPhoneNumber(CurrentParcel.SenderTelephone))
            {
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Sender's phone number is invalid.", "OK");
                return false;
            }

            if (!IsValidPhoneNumber(CurrentParcel.ReceiverTelephone))
            {
                await Application.Current.MainPage.DisplayAlert("Validation Error", "Receiver's phone number is invalid.", "OK");
                return false;
            }

            // All checks passed
            return true;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            if (phoneNumber.StartsWith("+254") && phoneNumber.Length == 13)
            {
                return phoneNumber.Substring(4).All(char.IsDigit);
            }
            else if (phoneNumber.StartsWith("07") && phoneNumber.Length == 10)
            {
                return phoneNumber.Substring(2).All(char.IsDigit);
            }

            return false;
        }

        private async Task OnDone()
        {
            if (_parcelService == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Parcel service is not initialized.", "OK");
                return;
            }
 
            try
            {
                // Show loading with custom message
                _loadingService.Show("Saving parcel...");
                
                if (!await ValidateParcelAsync()) 
                {
                    return;
                }

                if (CurrentParcel.Rate != null && CurrentParcel.Rate > 0 && CurrentParcel.Quantity != null && CurrentParcel.Quantity > 0)
                {
                    CurrentParcel.TotalAmount = (CurrentParcel.Rate ?? 0) * (CurrentParcel.Quantity ?? 0);
                }
                else
                {
                    CurrentParcel.TotalAmount = CurrentParcel.Amount ?? 0;
                }

                if (CurrentParcel.DispatchedAt.HasValue && CurrentParcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.DispatchedAt = CurrentParcel.DispatchedAt.Value.ToUniversalTime();
                }

                if (CurrentParcel.CreatedAt.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.CreatedAt = CurrentParcel.CreatedAt.ToUniversalTime();
                }

                CurrentParcel.CreatedById = CurrentUserId;

                // Update loading message for network operation
                _loadingService.Show("Connecting to server...");
                
                // Get the result from CreateParcelAsync which includes the waybill number from the server
                var updatedParcel = await _parcelService.CreateParcelAsync(CurrentParcel);
                
                // Update the current parcel with the waybill number
                if (updatedParcel != null && !string.IsNullOrEmpty(updatedParcel.WaybillNumber))
                {
                    CurrentParcel.WaybillNumber = updatedParcel.WaybillNumber;
                    CurrentParcel.QRCode = updatedParcel.QRCode;
                    Debug.WriteLine($"Updated current parcel with waybill number: {CurrentParcel.WaybillNumber}");
                }

                _loadingService.Show("Finalizing waybill...");
                await _parcelService.FinalizeWaybillAsync();

                if (_smsService != null && !string.IsNullOrEmpty(CurrentParcel.ReceiverTelephone))
                {
                    _loadingService.Show("Sending notification...");
                    try
                    {
                        // Check if SMS was already sent for this parcel
                        bool alreadySent = await _parcelService.CheckSmsNotificationSentAsync(CurrentParcel.Id);
                        
                        if (!alreadySent)
                        {
                            await _smsService.SendTemplatedParcelNotificationAsync(CurrentParcel);
                            Debug.WriteLine($"SMS notification sent for parcel {CurrentParcel.Id}");
                        }
                        else
                        {
                            Debug.WriteLine($"Skipping duplicate SMS for parcel {CurrentParcel.Id} - already sent");
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Failed to send SMS notification: {ex.Message}");
                    }
                }

                _loadingService.Show("Preparing receipt...");
                // Using the updated CurrentParcel with waybill number
                var receiptViewModel = ReceiptViewModelAdapter.CreateForSingleParcel(_parcelService, CurrentParcel);
                var receiptView = new ReceiptView(receiptViewModel);
                
                _loadingService.Hide();
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);

                ResetParcel();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
                _loadingService.Hide();
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
            }
            catch (Exception ex)
            {
                _loadingService.Hide();
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {ex.Message}", "OK");
            }
            finally
            {
                // Ensure loading indicator is hidden even if there's an unhandled exception
                _loadingService.Hide();
            }
        }

        public async Task AddParcelToCart(Parcel newParcel)
        {
            if (string.IsNullOrEmpty(WaybillNumber))
            {
                WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                newParcel.WaybillNumber = WaybillNumber;
            }

            Sender = newParcel.Sender;
            Receiver = newParcel.Receiver;

            newParcel.CreatedAt = DateTime.UtcNow;
            newParcel.Status = ParcelStatus.Pending;
            
            newParcel.CreatedById = CurrentUserId;

            if (newParcel.Quantity > 0 && newParcel.Rate > 0)
            {
                newParcel.Amount = newParcel.Quantity * newParcel.Rate;
            }
            else
            {
                newParcel.Amount = 0;
            }

            ParcelsInWaybill.Add(newParcel);

            OnPropertyChanged(nameof(ParcelsInWaybill));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(Sender));
            OnPropertyChanged(nameof(Receiver));
            OnPropertyChanged(nameof(TotalAmount));

            await Application.Current.MainPage.DisplayAlert("Success", "Parcel added to the current waybill.", "OK");
        }
        private async void OnEditParcel(Parcel parcel)
        {
            if (parcel != null)
            {
                CurrentParcel = parcel;

                await Application.Current.MainPage.Navigation.PopAsync();

                OnPropertyChanged(nameof(CurrentParcel));
            }
        }
        private void OnDeleteParcel(Parcel parcel)
        {
            if (parcel != null)
            {
                ParcelsInWaybill.Remove(parcel);
                UpdateCartTotalAmount();
                OnPropertyChanged(nameof(ParcelsInWaybill));
            }
        }
        private async Task OnCartDone()
        {
            try
            {
                _loadingService.Show("Checking connection...");
                
                if (!await _parcelService.CheckDatabaseConnectionAsync())
                {
                    var connectionString = "Check Debug Output for details";
                    Debug.WriteLine("CONNECTION ERROR: Cannot connect to the database using the configured connection string.");
                    
                    _loadingService.Hide();
                    await Application.Current.MainPage.DisplayAlert("Connection Error", 
                        $"Cannot connect to the database at 139.59.12.69. Please check your network connection and try again.\n\nDetails: {connectionString}", "OK");
                    return;
                }
                
                if (!_parcelService.IsNetworkAvailable())
                {
                    _loadingService.Hide();
                    await Application.Current.MainPage.DisplayAlert("Network Error", 
                        "No network connection available. Please check your internet connection and try again.", "OK");
                    return;
                }
                
                if (ParcelsInWaybill == null || !ParcelsInWaybill.Any())
                {
                    _loadingService.Hide();
                    await Application.Current.MainPage.DisplayAlert("Error", "No parcels in the cart to save.", "OK");
                    return;
                }

                _loadingService.Show("Generating waybill...");
                if (string.IsNullOrEmpty(WaybillNumber))
                {
                    WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                }

                // Make sure all parcels have the same waybill number
                foreach (var parcel in ParcelsInWaybill)
                {
                    parcel.WaybillNumber = WaybillNumber;
                    parcel.DispatchedAt = parcel.DispatchedAt?.ToUniversalTime();
                }

                Debug.WriteLine($"Saving {ParcelsInWaybill.Count} parcels with waybill: {WaybillNumber}");

                try
                {
                    _loadingService.Show("Saving parcels to server...");
                    // Save the parcels and get the updated list with waybill numbers
                    var savedParcels = await _parcelService.CreateCartParcels(ParcelsInWaybill.ToList());
                    
                    // Update the parcels in the waybill with the returned data
                    if (savedParcels != null && savedParcels.Any())
                    {
                        // Replace our collection with the updated parcels that have waybill numbers
                        ParcelsInWaybill = new ObservableCollection<Parcel>(savedParcels);
                        
                        // Update the waybill number from the first parcel if not already set
                        if (string.IsNullOrEmpty(WaybillNumber) && !string.IsNullOrEmpty(savedParcels.First().WaybillNumber))
                        {
                            WaybillNumber = savedParcels.First().WaybillNumber;
                            Debug.WriteLine($"Updated waybill number from saved parcels: {WaybillNumber}");
                        }
                    }
                    
                    Debug.WriteLine("CreateCartParcels completed successfully");

                    _loadingService.Show("Finalizing waybill...");
                    await _parcelService.FinalizeWaybillAsync();
                    Debug.WriteLine("FinalizeWaybillAsync completed successfully");
                    
                    if (_smsService != null)
                    {
                        _loadingService.Show("Sending notifications...");
                        foreach (var parcel in ParcelsInWaybill)
                        {
                            if (!string.IsNullOrEmpty(parcel.ReceiverTelephone))
                            {
                                try
                                {
                                    // Check if SMS was already sent for this parcel
                                    bool alreadySent = await _parcelService.CheckSmsNotificationSentAsync(parcel.Id);
                                    
                                    if (!alreadySent)
                                    {
                                        await _smsService.SendTemplatedParcelNotificationAsync(parcel);
                                        Debug.WriteLine($"SMS notification sent for parcel {parcel.Id}");
                                    }
                                    else
                                    {
                                        Debug.WriteLine($"Skipping duplicate SMS for parcel {parcel.Id} - already sent");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Debug.WriteLine($"Failed to send SMS notification for parcel {parcel.Id}: {ex.Message}");
                                }
                            }
                        }
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    _loadingService.Hide();
                    await Application.Current.MainPage.DisplayAlert("Connection Error", ioe.Message, "OK");
                    return;
                }

                var totalAmount = ParcelsInWaybill.Sum(p => p.Amount ?? 0);
                var paymentMethod = PaymentMethods;
                var paymentMethodsList = new ObservableCollection<string>(PaymentMethods);
                
                // Ensure we're using the correct waybill number and calculating total amount
                Debug.WriteLine($"Creating receipt with waybill number: {WaybillNumber}, total amount: {totalAmount}");
                
                // First update the TotalAmount property on all parcels
                foreach (var parcel in ParcelsInWaybill)
                {
                    parcel.TotalAmount = totalAmount;
                }
                
                _loadingService.Show("Preparing receipt...");
                var receiptViewModel = ReceiptViewModelAdapter.CreateForMultipleParcels(
                    _parcelService, 
                    new ObservableCollection<Parcel>(ParcelsInWaybill), 
                    WaybillNumber);

                _loadingService.Hide();
                await Application.Current.MainPage.DisplayAlert("Success", "All parcels in the waybill have been saved.", "OK");

                var receiptView = new ReceiptView(receiptViewModel);
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);
                CurrentWaybill = null;
                ResetCart();
            }
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                
                _loadingService.Hide();
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to process cart: {errorMessage}", "OK");
                
                Debug.WriteLine($"Error in OnCartDone: {ex}");
            }
            finally
            {
                // Ensure loading indicator is hidden in all cases
                _loadingService.Hide();
            }
        }

        private void OnPrintReceipt()
        {
            try
            {
                if (!ValidateParcelAsync().Result)
                {
                    return;
                }

                Application.Current.MainPage.DisplayAlert("Success", "Receipt printed successfully.", "OK");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Print error: {ex.Message}");
                Application.Current.MainPage.DisplayAlert("Error", "Failed to print receipt.", "OK");
            }
        }

        public void ResetParcel(bool keepSenderReceiverDetails = false)
        {
            if (CurrentParcel == null)
                CurrentParcel = new Parcel();

            var newParcel = new Parcel
            {
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending,
                WaybillNumber = CurrentParcel.WaybillNumber
            };

            if (keepSenderReceiverDetails)
            {
                newParcel.Sender = CurrentParcel.Sender;
                newParcel.SenderTelephone = CurrentParcel.SenderTelephone;
                newParcel.Receiver = CurrentParcel.Receiver;
                newParcel.ReceiverTelephone = CurrentParcel.ReceiverTelephone;
            }

            CurrentParcel = newParcel;
        }

        public void ResetCart()
        {
            ParcelsInWaybill.Clear();

            CurrentWaybill = null;

            WaybillNumber = string.Empty;
            Sender = string.Empty;
            Receiver = string.Empty;

            ResetParcel();

            OnPropertyChanged(nameof(ParcelsInWaybill));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(Sender));
            OnPropertyChanged(nameof(Receiver));
        }

        private async void OnViewParcels()
        {
            // Create a copy to pass to avoid potential issues with modifying the original collection during navigation
            var parcelsToView = new List<Parcel>(ParcelsInWaybill);

            // Pass the list as a navigation parameter using a RELATIVE route
            await Shell.Current.GoToAsync(nameof(ListParcelsView), new Dictionary<string, object>
            {
                { "ParcelsToDisplay", parcelsToView }
            });
        }

        private async Task BackToParcels()
        {
            IsReturningToView = true;

            ResetParcel(true);

            await Shell.Current.GoToAsync("..");
        }

        private async void OnAddParcel()
        {
            if (await ValidateParcelAsync())
            {
                await AddParcelToCart(CurrentParcel);

                ResetParcel(true);

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
            TotalAmount = Parcels.Sum(p => p.Amount ?? 0);
            OnPropertyChanged(nameof(TotalAmount));
        }

        public void UpdateCartTotalAmount()
        {
            TotalAmount = ParcelsInWaybill.Sum(parcel => parcel.Amount ?? 0);
            OnPropertyChanged(nameof(TotalAmount));
        }

        public void ResetAddParcel()
        {
            var sender = CurrentParcel.Sender;
            var senderTelephone = CurrentParcel.SenderTelephone;
            var receiver = CurrentParcel.Receiver;
            var receiverTelephone = CurrentParcel.ReceiverTelephone;
            var waybillNumber = CurrentParcel.WaybillNumber;

            CurrentParcel = new Parcel
            {
                Sender = sender,
                SenderTelephone = senderTelephone,
                Receiver = receiver,
                ReceiverTelephone = receiverTelephone,
                WaybillNumber = waybillNumber,
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending
            };
            OnPropertyChanged(nameof(CurrentParcel));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async Task RunPrinterDiagnostics()
        {
            try
            {
                await Shell.Current.GoToAsync($"//{nameof(Views.PrinterDiagnosticView)}");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Error navigating to printer diagnostics: {ex.Message}", "OK");
            }
        }

        public void PrintReceiptForSingleParcel(Parcel parcel)
        {
            try
            {
                if (parcel != null)
                {
                    var receiptViewModel = ReceiptViewModelAdapter.CreateForSingleParcel(_parcelService, parcel);
                }
            }
            catch (Exception ex)
            {
                // Handle exception...
            }
        }

        private void PrintReceiptForMultipleParcels(ObservableCollection<Parcel> parcels, string waybillNumber)
        {
            try
            {
                if (parcels != null && parcels.Count > 0)
                {
                    var receiptViewModel = ReceiptViewModelAdapter.CreateForMultipleParcels(_parcelService, parcels, waybillNumber);
                }
            }
            catch (Exception ex)
            {
                // Handle exception...
            }
        }
    }
}

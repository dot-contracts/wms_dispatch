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
        public string _senderTelephone { get; set; }
        public string _receiveTelephone { get; set; }
        public object CurrentWaybill { get; private set; }
        public bool IsReturningToView { get; set; } = false;
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
        public ICommand DeleteParcelCommand { get; }
        public ICommand EditParcelCommand { get; }



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
            DeleteParcelCommand = new RelayCommand<Parcel>(OnDeleteParcel);
            EditParcelCommand = new RelayCommand<Parcel>(OnEditParcel);

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
                return false;
            }

            // Validate the sender's and receiver's phone numbers
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

            return true;
        }


        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Check if the number starts with +254 (international format) or 07 (local format)
            if (phoneNumber.StartsWith("+254") && phoneNumber.Length == 13)
            {
                // Ensure the rest of the number is digits
                return phoneNumber.Substring(4).All(char.IsDigit);
            }
            else if (phoneNumber.StartsWith("07") && phoneNumber.Length == 10)
            {
                // Ensure the rest of the number is digits
                return phoneNumber.Substring(2).All(char.IsDigit);
            }

            return false;
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
                // Calculate TotalAmount based on Rate and Quantity
                if (CurrentParcel.Rate > 0 && CurrentParcel.Quantity > 0)
                {
                    CurrentParcel.TotalAmount = CurrentParcel.Rate * CurrentParcel.Quantity;
                }
                else
                {
                    CurrentParcel.TotalAmount = CurrentParcel.Amount;
                }

                // Ensure UTC timestamps
                if (CurrentParcel.DispatchedAt.HasValue && CurrentParcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.DispatchedAt = CurrentParcel.DispatchedAt.Value.ToUniversalTime();
                }

                if (CurrentParcel.CreatedAt.Kind != DateTimeKind.Utc)
                {
                    CurrentParcel.CreatedAt = CurrentParcel.CreatedAt.ToUniversalTime();
                }

                // Save the parcel to the database
                await _parcelService.CreateParcelAsync(CurrentParcel);

                // Finalize the waybill
                await _parcelService.FinalizeWaybillAsync();

                // Navigate to the receipt view
                var receiptViewModel = new ReceiptViewModel(_parcelService) { Parcel = CurrentParcel };
                var receiptView = new ReceiptView(receiptViewModel);
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptView);

                // Reset the form after saving
                ResetParcel();
            }
            catch (DbUpdateException dbEx)
            {
                var innerException = dbEx.InnerException != null ? dbEx.InnerException.Message : "No inner exception";
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {dbEx.Message}\nInner Exception: {innerException}", "OK");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to save parcel: {ex.Message}", "OK");
            }
        }


        public async Task AddParcelToCart(Parcel newParcel)
        {
            // If no waybill exists, generate one now
            if (string.IsNullOrEmpty(WaybillNumber))
            {
                WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                newParcel.WaybillNumber = WaybillNumber; // Assign to the parcel
            }



            // Set Sender and Receiver details
            Sender = newParcel.Sender;
            Receiver = newParcel.Receiver;

            // Set other parcel details
            newParcel.CreatedAt = DateTime.UtcNow;
            newParcel.Status = ParcelStatus.Pending;

            // Calculate the individual amount for the parcel based on rate and quantity
            if (newParcel.Quantity > 0 && newParcel.Rate > 0)
            {
                newParcel.Amount = newParcel.Quantity * newParcel.Rate;
            }
            else
            {
                newParcel.Amount = 0;  // Handle cases where quantity or rate is zero
            }

            // Add parcel to the cart for the current waybill
            ParcelsInWaybill.Add(newParcel);

            // Update UI list (e.g., ObservableCollection)
            OnPropertyChanged(nameof(ParcelsInWaybill));
            OnPropertyChanged(nameof(WaybillNumber));
            OnPropertyChanged(nameof(Sender));
            OnPropertyChanged(nameof(Receiver));
            OnPropertyChanged(nameof(TotalAmount));

            // Optionally show confirmation message
            await Application.Current.MainPage.DisplayAlert("Success", "Parcel added to the current waybill.", "OK");
        }
        private async void OnEditParcel(Parcel parcel)
        {
            if (parcel != null)
            {
                // Set the current parcel for editing (populate the fields in the form)
                CurrentParcel = parcel;

                // Optionally navigate back to the Add Parcel form for editing
                await Application.Current.MainPage.Navigation.PopAsync(); // Assuming this navigates back to the Add Parcel page

                // Notify the UI to update the form fields with the selected parcel's data
                OnPropertyChanged(nameof(CurrentParcel));
            }
        }
        private void OnDeleteParcel(Parcel parcel)
        {
            if (parcel != null)
            {
                ParcelsInWaybill.Remove(parcel); // Remove the selected parcel from the cart
                UpdateCartTotalAmount();         // Recalculate the total amount after deletion
                OnPropertyChanged(nameof(ParcelsInWaybill)); // Notify the UI to update
            }
        }
        private async Task OnCartDone()
        {
            try
            {
                // First validate
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

                // Generate waybill if needed
                if (string.IsNullOrEmpty(WaybillNumber))
                {
                    WaybillNumber = await _parcelService.GenerateWaybillNumberAsync();
                }

                // Process parcels
                //foreach (var parcel in ParcelsInWaybill)
                //{
                //    parcel.WaybillNumber = WaybillNumber;
                //    if (parcel.DispatchedAt.HasValue && parcel.DispatchedAt.Value.Kind != DateTimeKind.Utc)
                //    {
                //        parcel.DispatchedAt = parcel.DispatchedAt.Value.ToUniversalTime();
                //    }
                //}

                foreach (var parcel in ParcelsInWaybill)
                {
                    parcel.WaybillNumber = WaybillNumber;
                    parcel.DispatchedAt = parcel.DispatchedAt?.ToUniversalTime();
                }

                // Log the state before save
                Debug.WriteLine($"Saving {ParcelsInWaybill.Count} parcels with waybill: {WaybillNumber}");

                // Save operations
                await _parcelService.CreateCartParcels(ParcelsInWaybill.ToList());
                Debug.WriteLine("CreateCartParcels completed successfully");
                await _parcelService.FinalizeWaybillAsync();
                Debug.WriteLine("FinalizeWaybillAsync completed successfully");

                // Calculate total amount and set up ReceiptCartViewModel
                var totalAmount = ParcelsInWaybill.Sum(p => p.Amount);
                var paymentMethod = PaymentMethods; // Adjust as needed for specific payment method
                var receiptCartViewModel = new ReceiptCartViewModel(_parcelService, new ObservableCollection<Parcel>(ParcelsInWaybill), WaybillNumber, totalAmount, paymentMethod);


                // Success message
                await Application.Current.MainPage.DisplayAlert("Success", "All parcels in the waybill have been saved.", "OK");

                // Cleanup
                // Navigate to ReceiptCartView
                var receiptCartView = new ReceiptCartView { BindingContext = receiptCartViewModel };
                await Application.Current.MainPage.Navigation.PushModalAsync(receiptCartView);
                CurrentWaybill = null;
                ResetCart();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Failed to process cart: {ex.Message}", "OK");
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

        public void ResetParcel(bool keepSenderReceiverDetails = false)
        {
            if (CurrentParcel == null)
                CurrentParcel = new Parcel();

            // Reset the fields for the new parcel
            var newParcel = new Parcel
            {
                CreatedAt = DateTime.UtcNow,
                Status = ParcelStatus.Pending,
                WaybillNumber = CurrentParcel.WaybillNumber // Keep the same waybill number if it's already set
            };

            // Retain Sender and Receiver details if instructed to do so
            if (keepSenderReceiverDetails)
            {
                newParcel.Sender = CurrentParcel.Sender;
                newParcel.SenderTelephone = CurrentParcel.SenderTelephone;
                newParcel.Receiver = CurrentParcel.Receiver;
                newParcel.ReceiverTelephone = CurrentParcel.ReceiverTelephone;
            }

            // Assign the newly created parcel object back to CurrentParcel
            CurrentParcel = newParcel;
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
            // Set flag to prevent resetting the entire view
            IsReturningToView = true;

            // Call ResetAddParcel to preserve sender and receiver details
            ResetParcel(true);

            // Navigate back to the previous page (ParcelView)
            await Application.Current.MainPage.Navigation.PopAsync();
        }



        private async void OnAddParcel()
        {
            if (await ValidateParcelAsync()) // Validate current parcel data
            {
                // Add the parcel to the cart, linking it to the waybill
                await AddParcelToCart(CurrentParcel);

                // Reset the view but retain sender/receiver details
                ResetParcel(true);

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
            // Notify the UI of the changes
            OnPropertyChanged(nameof(CurrentParcel));
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

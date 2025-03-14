using System.Collections.ObjectModel;
using System.Windows.Input;
using TrafficViolation.BLL.Services;
using TrafficViolation.DAL.Models;

namespace TrafficViolation.PaymentControll
{
    public class ManagePaymentsViewModel : ViewModelBase
    {
        private readonly PaymentService _paymentService;
        public ObservableCollection<Payment> Payments { get; set; }

        public ICommand ViewPaymentCommand { get; }

        public ManagePaymentsViewModel()
        {
            _paymentService = new PaymentService();
            Payments = new ObservableCollection<Payment>(_paymentService.GetAllPayments());

            ViewPaymentCommand = new RelayCommand<int>(ViewPayment);
        }

        private void ViewPayment(int paymentId)
        {
            Payment payment = _paymentService.GetPaymentById(paymentId);
            // Mở cửa sổ chi tiết thanh toán
            ViewPayment viewPayment = new ViewPayment(payment);
            viewPayment.Show();
        }
    }
}
namespace BalloonParty.Core.Models
{
    public class CustomerOrders
    {
        private string _CustomerEmail { get; set; }
        private DateTime _OrderDate { get; set; }
        private int _FullProductCount { get; set; }
        private decimal _TotalPrice { get; set; }
        private int _CustomerOrderId { get; set; }
        private string _ProductName { get; set; }


        public string  CustomerEmail
        {
            get => _CustomerEmail;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _CustomerEmail = value;
            }
        }

        public string  OrderDate
        {
            get => _OrderDate;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _OrderDate = value;
            }
        }

        public string  FullProductCount
        {
            get => _FullProductCount;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _FullProductCount = value;
            }
        }

        public string  TotalPrice
        {
            get => _TotalPrice;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _TotalPrice = value;
            }
        }

        public string  CustomerOrderId
        {
            get => _CustomerOrderId;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _CustomerOrderId = value;
            }
        }

        public string  ProductName
        {
            get => _ProductName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("First Name Must Not Be Empty.", nameof(value));
                }
                _ProductName = value;
            }
        }
    }
}
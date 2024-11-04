namespace VivaStore.PL.Areas.Dashboard.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; } 
        public DateTime OrderDate { get; set; }
        public string PaymentMethod { get; set; }
		public string ShippingAddress { get; set; }
        public decimal TotalAmount { get; set; }
		public string Status { get; set; } 
        public List<OrderItemVM> OrderItems { get; set; } = new List<OrderItemVM>();
    }
}

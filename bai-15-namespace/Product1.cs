namespace Sanpham
{
    public partial class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public string GetInfo()
        {
            return $"{this.name}/ {this.price}: {this.description}";
        }
    }
}
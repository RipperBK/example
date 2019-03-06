namespace ClassLibrary
{
    public class LineItem
    {
        public LineItem()
        {
                
        }

        public LineItem(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
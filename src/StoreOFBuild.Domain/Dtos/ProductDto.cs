namespace StoreOFBuild.Domain.Dtos
{
    public class ProductDto
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int CategoryId {get; private set;}
        public decimal  Price {get; set;}
        public int StockQuantity {get; private set;}
    }
}
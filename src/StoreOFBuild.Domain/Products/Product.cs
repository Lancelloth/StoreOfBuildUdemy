namespace StoreOFBuild.Domain.Products
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public Category Category {get; private set;}
        public decimal  Price {get; set;}
        public int StockQuantity {get; private set;}
        
        public Product(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues (name, category, price, stockQuantity);
            SetValues (name, category, price, stockQuantity); 
        }

        public void Update(string name, Category category, decimal price, int stockQuantity)
        {
            ValidateValues (name, category, price, stockQuantity);
            SetValues (name, category, price, stockQuantity); 
        }

        private void SetValues (string name, Category category, decimal price, int stockQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockQuantity;
        }

        private static void ValidateValues (string name, Category category, decimal price, int stockQuantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "O nome é necessário");
            DomainException.When(category == null, "Categoria não pode ser nula");
            DomainException.When(price < 0, "O preço não pode ser negativo");
            DomainException.When(stockQuantity < 0, "O estoque não pode ser negativo");
        }
    }
}
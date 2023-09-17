namespace FormApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();
        
        static Repository()
        {
            _categories.Add(new Category{CategoryId = 1,Name ="Telefon"});
            _categories.Add(new Category{CategoryId = 2,Name ="Bilgisayar"});

            _products.Add(new Product{ProductId = 1,Name = "Samsung S20",Price = 40000,IsActive=true,Image="1.jpg",CategoryId = 1});
            _products.Add(new Product{ProductId = 2,Name = "Samsung S21",Price = 50000,IsActive=true,Image="2.jpg",CategoryId = 1});
            _products.Add(new Product{ProductId = 3,Name = "Samsung S22",Price = 60000,IsActive=true,Image="3.jpg",CategoryId = 1});
            _products.Add(new Product{ProductId = 4,Name = "Samsung S22",Price = 70000,IsActive=true,Image="4.jpg",CategoryId = 1});
            
            _products.Add(new Product{ProductId = 5,Name = "Macbook",Price = 80000,IsActive=true,Image="laptop.jpeg",CategoryId = 2});
            _products.Add(new Product{ProductId = 6,Name = "Macbook Pro",Price = 85000,IsActive=true,Image="laptop2.jpeg",CategoryId = 2});

        }

        public static List<Product> Products
        {
            get 
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId == updatedProduct.ProductId);

            if(entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            } 
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault(p=>p.ProductId == deletedProduct.ProductId);

            if(entity != null)
            {
                _products.Remove(entity);
            }
        }
        public static List<Category> Categories
        {
            get 
            {
                return _categories;
            }
        }

    }
}

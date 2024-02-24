namespace LinqProject;

class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Bilgisayar"},
            new Category{CategoryId=2, CategoryName="Telefon"},
        };

        List<Product> products = new List<Product>
        {
            new Product{ProductId=1, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram",  UnitPrice=10000, UnitsInStock=100 },
            new Product{ProductId=2, CategoryId=1, ProductName="ACER Laptop", QuantityPerUnit="32 GB Ram",  UnitPrice=20000, UnitsInStock=5 },
            new Product{ProductId=3, CategoryId=1, ProductName="ASUS Laptop", QuantityPerUnit="16 GB Ram",  UnitPrice=15000, UnitsInStock=10 },
            new Product{ProductId=4, CategoryId=1, ProductName="CASPER Laptop", QuantityPerUnit="8 GB Ram",  UnitPrice=9000, UnitsInStock=200 },
            new Product{ProductId=5, CategoryId=1, ProductName="MONSTER Laptop", QuantityPerUnit="16 GB Ram",  UnitPrice=15000, UnitsInStock=200 },
            new Product{ProductId=6, CategoryId=2, ProductName="Redmi Note 10 Pro", QuantityPerUnit="8+2 GB Ram",  UnitPrice=15000, UnitsInStock=5000 },
            new Product{ProductId=7, CategoryId=2, ProductName="Apple IPhone 11", QuantityPerUnit="8 GB Ram",  UnitPrice=25000, UnitsInStock=1000 },
        };

        Console.WriteLine("---------------------------------- Algoritmik ----------------------------------");

        foreach (var product in products)
        {
            if (product.UnitPrice > 10000 && product.UnitsInStock > 500)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        Console.WriteLine("---------------------------------- Linq ----------------------------------");

        var result = products.Where(product => product.UnitPrice > 10000 && product.UnitsInStock > 500);

        foreach (var product in result)
        {        
            Console.WriteLine(product.ProductName);           
        }

        GetProducts(products);
    }

    static List<Product> GetProducts(List<Product> products)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (var product in products)
        {
            if (product.UnitPrice > 10000 && product.UnitsInStock > 500)
            {
                filteredProducts.Add(product);
            }
        }

        return filteredProducts;

    }

    static List<Product> GetProductsLinq(List<Product> products)
    {
        return products.Where(product => product.UnitPrice > 10000 && product.UnitsInStock > 500).ToList();
    }



}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }

}
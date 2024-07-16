
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>()
{
   new Product()
   {
   Name = "Trumpet",
   Price = 20.00M,
   ProductTypeId = 1,
   },
   new Product()
   {
       Name = "Romeo & Juliet",
       Price = 50.00M,
       ProductTypeId = 2,
   },
   new Product()
   {
    Name = "Trombone",
    Price = 200.00M,
    ProductTypeId = 1,
    },
   new Product()
   {
       Name = "McBeth",
       Price = 50.00M,
       ProductTypeId = 2,
   },
   new Product()
   {
       Name = "Tuba",
       Price = 100.00M,
       ProductTypeId = 1,
   },
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    },
};
//put your greeting here
Console.WriteLine("Welcome to Brazz & Poem!");

//implement your loop here
DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"Chose an option:
    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit");

        choice = Console.ReadLine();
        if (choice == "1")
        {
            // DisplayAllProducts();
        }
        else if (choice == "2")
        {
            // AddProduct();
        }
        else if (choice == "3")
        {
            // DeleteProduct();
        }
        else if (choice == "4")
        {
            // UpdateProduct();
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }
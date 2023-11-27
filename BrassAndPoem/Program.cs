List<Product> products = new List<Product>()
{
    new Product()
    {
        // name
        Name = "trumpet",
        // price
        Price = 599.99M,
        // producttypeid
        ProductTypeId = 2
    },
    new Product()
    {
        // name
        Name = "french horn",
        // price
        Price = 699.99M,
        // producttypeid
        ProductTypeId = 2
    },
    new Product()
    {
        // name
        Name = "trombone",
        // price
        Price = 799.99M,
        // producttypeid
        ProductTypeId = 2
    },
    new Product()
    {
        // name
        Name = "words of a goat princess",
        // price
        Price = 49.99M,
        // producttypeid
        ProductTypeId = 1
    },
    new Product()
    {
        // name
        Name = "last leaves",
        // price
        Price = 39.99M,
        // producttypeid
        ProductTypeId = 1
    }
};
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Id = 1,
        Title = "poetry book"
    },
    new ProductType()
    {
        Id = 2,
        Title = "brass musical instrument"
    }
};
DisplayWelcome();
string chosenOption = null;
while (chosenOption != "5")
{
    // DisplayMenu
    DisplayMenu();
    chosenOption = Console.ReadLine().Trim();
    if (chosenOption == "1")
    {
        // DisplayAllProducts
        DisplayAllProducts(products, productTypes);
    }
    else if (chosenOption == "2")
    {
        // DeleteProduct
        DeleteProduct(products, productTypes);
    }
    else if (chosenOption == "3")
    {
        // AddProduct
        AddProduct(products, productTypes);
    }
    else if (chosenOption == "4")
    {
        // UpdateProduct
        UpdateProduct(products, productTypes);
    }
    else if (chosenOption == "5")
    {
        Console.WriteLine("goodbye");
    }
}
void DisplayWelcome()
{
    string welcome = "welcome to the brass & poem";
    Console.WriteLine(welcome);
};
void DisplayMenu()
{
    Console.WriteLine(@"choose one of the following...
    1. display all products
    2. delete a product
    3. add a product
    4. update a product
    5. end application");
}
void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Product chosenProoduct = products[i];
        Console.WriteLine($"{i + 1}. {chosenProoduct.Name} costs ${chosenProoduct.Price}");
    }
}
void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Product chosenProduct = null;
    while (chosenProduct == null)
    {
        try
        {
            Console.WriteLine("choose an item to delete.....");
            DisplayAllProducts(products, productTypes);
            int response = int.Parse(Console.ReadLine().Trim()) - 1;
            chosenProduct = products[response];
            Console.WriteLine($"you chose to delete {chosenProduct.Name}...");
            products.RemoveAt(response);
        }
        catch (FormatException)
        {
            Console.WriteLine("wrong format");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("out of range");
        }
    }
}
void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Product newProduct = new Product();
    Console.WriteLine(newProduct.Price);
    while (newProduct.Name == null || newProduct.Price == 0 || newProduct.ProductTypeId == 0)
    {
        if (newProduct.Name == null)
        {
            Console.WriteLine("enter a name for your product");
            newProduct.Name = Console.ReadLine().Trim();
        }
        if (newProduct.Price == 0)
        {
            try
            {
                Console.WriteLine("enter a price for your product");
                newProduct.Price = decimal.Parse(Console.ReadLine().Trim());
            }
            catch (FormatException) { Console.WriteLine("wrong format"); }
        }
        if (newProduct.ProductTypeId == 0)
        {
            try
            {
                Console.WriteLine("choose one of the following types");
                for (int i = 0; i < productTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
                }
                newProduct.ProductTypeId = productTypes[int.Parse(Console.ReadLine().Trim()) - 1].Id;
                Console.WriteLine(newProduct.ProductTypeId);
            }
            catch (FormatException) { Console.WriteLine("wrong format"); }
            catch (ArgumentOutOfRangeException) { Console.WriteLine("out of range"); }
        }
    }
    products.Add(newProduct);
}
void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("choose a product to update...");
    DisplayAllProducts(products, productTypes);
    Product chosenProduct = null;
    while (chosenProduct == null)
    {
        try
        {
            chosenProduct = products[int.Parse(Console.ReadLine().Trim()) - 1];
        }
        catch (FormatException) { Console.WriteLine("wrong format"); }
        catch (ArgumentOutOfRangeException) { Console.WriteLine("out of range"); }
    }
    Console.WriteLine("enter a new product name");
    string updatedName = Console.ReadLine().Trim();
    if (string.IsNullOrWhiteSpace(updatedName))
    {
        Console.WriteLine("you didnt change the name");
    }
    else if (updatedName != null)
    {
        chosenProduct.Name = updatedName;
        Console.WriteLine($"new name is {chosenProduct.Name}");
    }
    Console.WriteLine("enter a new product price");
    decimal updatedPrice = 0M;
    while (updatedPrice == 0)
    {
        try
        {
            updatedPrice = decimal.Parse(Console.ReadLine().Trim());
            if (updatedPrice == chosenProduct.Price)
            {
                Console.WriteLine("you didnt change the price");
            }
            else if (updatedPrice <= 0)
            {
                Console.WriteLine("item cannot be free");
            }
            else
            {
                chosenProduct.Price = updatedPrice;
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("wrong format... price will remain the same");
            updatedPrice = chosenProduct.Price;
        }
    }
}
// don't move or change this!
public partial class Program { }
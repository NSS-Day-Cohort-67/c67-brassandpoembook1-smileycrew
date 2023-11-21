
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

//put your greeting here

//implement your loop here
// // **********
// Create the program loop
// Declare a list of product types and a list of products. When creating the lists, add at least two product types and five products.
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
        Name = "words of a goat pricess",
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
// Display a welcome message for the application
string welcome = "welcome to the brass & poem";
Console.WriteLine(welcome);
// Create a loop that asks the user to choose an option, and will continue running until the use selects 5, at which point the program will finish.
DisplayMenu();
string chosenOption = null;
while (chosenOption != "5")
{
    chosenOption = Console.ReadLine().Trim();
    if (chosenOption == "1")
    {
        throw new NotImplementedException();
    }
    else if (chosenOption == "2")
    {
        throw new NotImplementedException();
    }
    else if (chosenOption == "3")
    {
        throw new NotImplementedException();
    }
    else if (chosenOption == "4")
    {
        throw new NotImplementedException();
    }
    else if (chosenOption == "5")
    {
        Console.WriteLine("goodbye");
    }
}
// **********

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
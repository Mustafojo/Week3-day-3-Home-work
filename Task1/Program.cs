
var BMW = new Product();
BMW.ID = 1;
BMW.Name = "M5 F90";
BMW.Price = 120000;
BMW.Color = "black";

var MerseddesBenz = new Product();
MerseddesBenz.ID = 2;
MerseddesBenz.Name = "SClass223";
MerseddesBenz.Price = 120000;
MerseddesBenz.Color = "white";


var Iphone = new Product();
Iphone.ID = 3;
Iphone.Name = "Iphone 15";
Iphone.Price = 14000;
Iphone.Color = "Green";

var Sumsung = new Product();
Sumsung.ID = 4;
Sumsung.Name = "Galaxy S23";
Sumsung.Price = 14000;
Sumsung.Color = "black";




System.Console.WriteLine("ID: " + BMW.ID);
System.Console.WriteLine("Name: " + BMW.Name);
System.Console.WriteLine("Price: " + BMW.Price);
System.Console.WriteLine("Color: " + BMW.Color);
System.Console.WriteLine("----------------------");


System.Console.WriteLine("ID: " + MerseddesBenz.ID);
System.Console.WriteLine("Name: " + MerseddesBenz.Name);
System.Console.WriteLine("Price: " + MerseddesBenz.Price);
System.Console.WriteLine("Color: " + MerseddesBenz.Color);
System.Console.WriteLine("----------------------");



System.Console.WriteLine("ID: " + Iphone.ID);
System.Console.WriteLine("Name: " + Iphone.Name);
System.Console.WriteLine("Price: " + Iphone.Price);
System.Console.WriteLine("Color: " + Iphone.Color);
System.Console.WriteLine("----------------------");



System.Console.WriteLine("ID: " + Sumsung.ID);
System.Console.WriteLine("Name: " + Sumsung.Name);
System.Console.WriteLine("Price: " + Sumsung.Price);
System.Console.WriteLine("Color: " + Sumsung.Color);
System.Console.WriteLine("----------------------");







public class Product
{
    public int ID;
    public string Name;
    public double Price;
    public string Color;

}


class Car : Product
{
    public string Model;
    public Car(int id, string name, double price, string color,string model)
    {
        Model = model;
    }
    public List<Product> productho = new List<Product>();

    public void AddProduct(Product product)
    {
        productho.Add(product);
    }
    public string RemoveProduct(int id)
    {
        foreach (var item in productho)
        {
            if (item.ID == id)
            {
                productho.Remove(item);
                return "Product successfully deleted";
            }

        }
        return "Product not found";

    }
    public void PrintProductList()
    {
        System.Console.WriteLine("ID: " + ID);
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Price: " + Price);
        System.Console.WriteLine("Color: " + Color);
        System.Console.WriteLine("Model: " + Model);

    }

}

class Phone : Product
{
    public string Model;

    
    public Phone(int id, string name, double price, string color,string model)
    {
        Model = model;
    }
    public List<Product> productho = new List<Product>();

    public void AddProduct(Product product)
    {
        productho.Add(product);
    }
    public string RemoveProduct(int id)
    {
        foreach (var item in productho)
        {
            if (item.ID == id)
            {
                productho.Remove(item);
                return "Product successfully deleted";
            }

        }
        return "Product not found";

    }
    public void PrintProductList()
    {
        System.Console.WriteLine("ID: " + ID);
        System.Console.WriteLine("Name: " + Name);
        System.Console.WriteLine("Price: " + Price);
        System.Console.WriteLine("Color: " + Color);
        System.Console.WriteLine("Model: " + Model);

    }

}
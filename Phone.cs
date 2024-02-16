using System;


public class Phone
{	
	public Phone() 
	{
		Color = "Black";
		Price = 100; //Разобраться с символом
                     //NumberFormatInfo.CurrentInfo.CurrencySymbol
    }

    public Phone(string brand, string operationSystem, string color, double price)
	{ 
		Brand = brand;
		OperationSystem = operationSystem;
		Color = color;
		Price = price;
	}

	public string OperationSystem { get; set; }
	public string Color { get; set; }
	public double Price { get; set; }
	public string Brand { get; set; }






	
}

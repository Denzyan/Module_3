

public class Phone
{
	public Phone()
	{
		Color = "Black";
		Price = 100;
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
	private double Price { get; set; }
	public string Brand { get; set; }

	private double LocalTax { get; set; } = 0.13;
	public void PhoneBoot ()
	{
		Console.WriteLine($"{Brand}\t{OperationSystem}\t{Color}\t{Price}");
	}
	public void SetPhonePrice (double price)
	{
        Price = price;
        Console.WriteLine($"Phone price set - {Price}");
    }
	public double GetPhonePriceWithTax()
	{
		double priceWithTax = Price * LocalTax + Price;
		return priceWithTax;
	}
    public void SetProvinceTax (string province)
	{
		switch (province.ToLower())
		{	
			case "mb":
				LocalTax = 0.13;
				break;
			case "on":
				LocalTax = 0.12;
				break;
			case "sk":
				LocalTax = 0.1;
				break;
			case "ab":
				LocalTax = 0.08;
				break;
			case "bc":
				LocalTax = 0.11;
				break;
			default: 
				Console.WriteLine("wrong enter Province");
				break;
		}
	}
    
}

















// HOME WORK "CLASS + METODS"

Phone sony = new Phone();

sony.PhoneBoot();


Phone nokia = new Phone("Nokia", "Android", "Yellow", 333);

nokia.PhoneBoot();

nokia.SetPhonePrice(388);

nokia.SetProvinceTax("qb");
nokia.SetProvinceTax("bc");

double newprice = nokia.GetPhonePriceWithTax();

Console.WriteLine($"Phone '{nokia.Brand}' price with tax - {newprice}$");

// Так и не разобрался с NumberFormatInfo.CurrentInfo.CurrencySymbol
//  ? Возможно причина в локации.




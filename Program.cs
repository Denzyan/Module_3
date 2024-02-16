using System.ComponentModel.Design;
using System.Globalization;
using System.Net.Sockets;
using System.Security.AccessControl;

// HOME WORK "CLASS + METODS"
var sony = new Phone();
sony.Color = "DarkGreen";
sony.Price = 765;
sony.OperationSystem = "Android";
sony.Brand = "SONY";

var nokia = new Phone();

Console.WriteLine(sony.Brand + " " + sony.Color + " " + sony.Price);

Console.WriteLine($"{nokia.Brand} {nokia.Color} {nokia.Price} {nokia.OperationSystem}");

NumberFormatInfo currencySymbol = new NumberFormatInfo
{
    CurrencySymbol = "$"
};
Console.WriteLine(nokia.Price + "$", currencySymbol);



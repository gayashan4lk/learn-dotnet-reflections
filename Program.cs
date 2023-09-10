// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Text;
using MyApp.Models;

var tAddress = typeof(Address);

Console.WriteLine("***** Address Fields *****");
var addressFields = tAddress.GetFields();
foreach (var field in addressFields)
{
	Console.WriteLine($"Name:{field.Name} Type:{field.FieldType}\n");
}

Console.WriteLine("***** Address Properties *****");
var addressProperties = tAddress.GetProperties();
foreach (PropertyInfo property in addressProperties)
{
	Console.Write($"Name:{property.Name} Type:{property.PropertyType}\n");
}

var tCustomer = typeof(Customer);

Console.WriteLine("***** Customer Fields *****");
var customerFields = tCustomer.GetFields();
foreach (var field in customerFields)
{
	Console.WriteLine($"Name:{field.Name} Type:{field.FieldType}\n");
}

Console.WriteLine("***** Customer Properties *****");
var customerProperties = tCustomer.GetProperties();
foreach (var property in customerProperties)
{
	Console.Write($"Name:{property.Name} Type:{property.PropertyType}\n");
}

Console.WriteLine("***** Customer Methods *****");
var customerMethods = tCustomer.GetMethods();
foreach (var m in customerMethods)
{
	var paramInfo = new StringBuilder();
	var parameters = m.GetParameters();
	foreach (var p in parameters)
	{
		paramInfo.Append(string.Format($"{p.Name} ({p.ParameterType}) | "));
	}
	Console.WriteLine($"Method Name:{m.Name} Parameters: {paramInfo.ToString()} ReturnParameters:{m.ReturnParameter} ReturnType:{m.ReturnType}\n");
}

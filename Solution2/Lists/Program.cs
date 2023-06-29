// See https://aka.ms/new-console-template for more information
using Lists;
using System.Diagnostics;

//Console.WriteLine("Hello, World!");


//var Egypt = new Country() { Name = "Egypt", IsoCode = "EGY" };
//var jordan = new Country() { Name = "Jordan", IsoCode = "JOR" };

//Country[] Countries = {Egypt ,jordan };

//List<Country> Countries2 = new List<Country>();
//Countries2.Add(Egypt);
//Countries2.Add(jordan);///////// O(1) =1
//Countries2.Add(new Country { Name="Brasil", IsoCode="BRA"});
//Countries2.AddRange(new Country[] { Egypt, jordan });

//Countries2.Insert(1, new Country() { Name = "France", IsoCode = "FRA" });///////O(n)=n

//Countries2.AddRange(new Country[] { Egypt, jordan });

//foreach (var item in Countries2)
//{
//    Console.WriteLine(item.ToString());
//}
//Console.WriteLine(Countries2.Count);/////Actual Number of element
//Console.WriteLine(Countries2.Capacity);///initial Capacity for inner data storage

Console.WriteLine($"Process Id : {Process.GetCurrentProcess().Id}");
Console.WriteLine($"Thread Id : {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Processer Id : {Thread.GetCurrentProcessorId()}");
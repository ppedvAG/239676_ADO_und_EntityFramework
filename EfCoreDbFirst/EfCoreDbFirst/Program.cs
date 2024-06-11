// See https://aka.ms/new-console-template for more information
using EfCoreDbFirst.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var con = new HalloEfCoreContext();

var query = con.Mitarbeiters.Include(x=>x.IdNavigation).ToList();
foreach (var m in query)
{
    Console.WriteLine($"{m.IdNavigation.DerName}");
}

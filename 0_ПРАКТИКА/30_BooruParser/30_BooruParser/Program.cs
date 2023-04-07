
using _30_BooruParser.Parser;
using BooruSharp.Booru;

BooruParser parser = new BooruParser(new Yandere());
var res = parser.ParseById(22).Result;
Console.WriteLine(res);
Console.WriteLine("-------------------");
var res1 = parser.ParseByTag(10,"sex").Result;
foreach(var item in res1)
{
    Console.WriteLine(item);
}
Console.ReadLine();
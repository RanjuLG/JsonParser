using JsonParser;
using System.IO;
using System.Text.Json;

class ReadJsonFile
{
    static void Main()
    {
        string text = File.ReadAllText(@"D:\Documents\Tasks\JsonParser\sample2.json");
        var person = JsonSerializer.Deserialize<Person>(text);
      

        Console.WriteLine(person.firstName);
        Console.WriteLine(person.lastName);
        Console.WriteLine(person.age);
        Console.WriteLine(person.address[0].city);
    }
}
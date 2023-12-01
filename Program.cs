using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

class Program
{
    static async Task Main(string[] args)
    {   
        List<Tuple<string, string, string, string>> listA = new List<Tuple<string, string, string, string>>();
        using (var reader = new StreamReader(@"..//..//..//exhibitA-input.csv"))
        {
            var line = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split('	');
                listA.Add(new Tuple<string, string, string, string>(values[0], values[1], values[2], values[3]));
            }
        }
        var Song346Distinct = listA.Where(x => (x.Item2 == "346")).Select(x => x.Item3).Distinct().Count();
        var SingMaxDistict = listA.Select(x => x.Item2).Distinct().Count();
  
        Console.WriteLine($"Users which played 346 distinct songs: {Song346Distinct}");
        Console.WriteLine($"      ");
        Console.WriteLine($"Maximum number of distinct songs: {SingMaxDistict}");
          
        Console.ReadLine(); 
    }
}

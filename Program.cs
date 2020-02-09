using System;
using System.Collections.Generic;

namespace GitlabApi 
{
    class Program
    {
        static void Main()
        {
            var lines = new List<string>();
            string line; 

            while((line = Console.ReadLine()) != null) {
                lines.Add(line);
            }

            Console.WriteLine($"got: {String.Join('\n', lines.ToArray())}");
        }
    }
}

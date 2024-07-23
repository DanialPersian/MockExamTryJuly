using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\Dania\source\repos\MockExamTryJuly\Q6\dogOwners4.txt"; // Ensure this path is correct for your setup
        var owners = new List<Owner>();

        // Read the file line by line
        foreach (var line in File.ReadLines(filePath))
        {
            // Split the line into the owner's name and the dogs section
            var parts = line.Split(new[] { ':' }, 2);
            if (parts.Length == 2)
            {
                var ownerName = parts[0].Trim();
                var dogsSection = parts[1].Trim(new[] { '[', ']' });

                // Split the dogs section into individual dogs
                var dogs = dogsSection.Split(',').Select(d => d.Split(':')[0].Trim()).ToList();

                // Add the owner and their dogs to the list
                owners.Add(new Owner { Name = ownerName, Dogs = dogs });
            }
        }

        // Find owners whose names begin with "B" and have less than 3 dogs
        var count = owners.Count(o => o.Name.StartsWith("B") && o.Dogs.Count < 3);

        // Output the result
        Console.WriteLine($"Number of owners with names beginning with 'B' who have less than 3 dogs: {count}");
    }
}

class Owner
{
    public string Name { get; set; }
    public List<string> Dogs { get; set; }
}

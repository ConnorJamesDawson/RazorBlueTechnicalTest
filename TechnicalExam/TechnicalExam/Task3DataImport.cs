using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TechnicalExam;

public class Task3DataImport
{
    const string csvPath = $"C:/Users/conno/Desktop/RazorBlue";
    public void GrabDataFromCSV()
    {
        string[] lines = File.ReadAllLines(@"../Technical Test Data.csv");

        CheckReg(lines);
    }

    static void GetPetrol(IEnumerable<string> lines)
    {
        var petrolQuery = from line in lines
                          let elements = line.Split(',')
                          where elements[4].Contains("Petrol")
                          select elements;

        var petrolCsv = new StringBuilder();
        foreach (var entry in petrolQuery)
        {
            var first = entry[0];
            var second = entry[4];
            var newLine = String.Format("{0}, {1}", first, second);
            petrolCsv.AppendLine(newLine);
        }
        File.WriteAllText(csvPath, petrolCsv.ToString());
    }

    static void GetDiesel(IEnumerable<string> lines)
    {
        var dieselQuery = from line in lines
                          let elements = line.Split(',')
                          where elements[4].Contains("Diesel")
                          select elements;

        var dieselCsv = new StringBuilder();
        foreach (var entry in dieselQuery)
        {
            var first = entry[0];
            var second = entry[4];
            var newLine = String.Format("{0}, {1}", first, second);
            dieselCsv.AppendLine(newLine);
        }
        File.WriteAllText(csvPath, dieselCsv.ToString());
    }

    static void GetElectric(IEnumerable<string> lines)
    {
        var electricQuery = from line in lines
                            let elements = line.Split(',')
                            where elements[4].Contains("Electric")
                            select elements;

        var electricCsv = new StringBuilder();
        foreach (var entry in electricQuery)
        {
            var first = entry[0];
            var second = entry[4];
            var newLine = String.Format("{0}, {1}", first, second);
            electricCsv.AppendLine(newLine);
        }
        File.WriteAllText(csvPath, electricCsv.ToString());
    }

    static void CheckReg(IEnumerable<string> lines)
    {
        var regQuery = from line in lines
                            let elements = line.Split(',')
                            select elements[0];
        int validRegs = 0;
        foreach(var entry in regQuery)
        {
            if (Regex.IsMatch(entry, @"[A-Z]{2}\d{2} [A-Z]{3}", RegexOptions.IgnoreCase))
            {
                Console.WriteLine($"{entry} License is valid");
                validRegs++;
            }
            else
            {
                Console.WriteLine($"{entry} License is invalid");
            }
        }
        Console.WriteLine($"Number of valid Regs is: {validRegs} Number of invalid Regs: {(regQuery.Count() - validRegs) - 1}");
    }
}

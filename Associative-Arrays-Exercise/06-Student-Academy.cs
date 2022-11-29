using System;
using System.Collections.Generic;
using System.Linq;
 
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
 
            Dictionary<string, double> students = new Dictionary<string, double>();
            Dictionary<string, double> avarage = new Dictionary<string, double>();
 
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
 
                if(!students.ContainsKey(name))
                {
                    students[name] = 0;
                    avarage[name] = 0;
 
                }
                students[name] += grade;
                avarage[name]++;
            }
 
            foreach (var kvp in students)
            {
                string name = kvp.Key;
                double totalGrades = kvp.Value;
                double count = avarage[name];
 
                double averageGrade = totalGrades / count;
 
                if (averageGrade >= 4.50)
                {
                    Dictionary<string, double> studentsAvarage = new Dictionary<string, double>();
 
                    if (!studentsAvarage.ContainsKey(name))
                    {
                        studentsAvarage[name] = 0;
                    }
                  
                    studentsAvarage[name] = averageGrade;
                    var a = studentsAvarage.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
 
                    foreach (var item in a)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value:F2}");
                    }
                }
            }
        }
    }
}

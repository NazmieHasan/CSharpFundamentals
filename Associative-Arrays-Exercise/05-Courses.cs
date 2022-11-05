using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();
            
            string command;
            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" : ");
                string courseName = cmdArgs[0];
                string studentName = cmdArgs[1];
                
                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                
                coursesInfo[courseName].Add(studentName);
            }
            
            foreach (var course in coursesInfo)
            {
                string courseName = course.Key;
                List<string> students = course.Value;
                
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (string studentName in students)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}

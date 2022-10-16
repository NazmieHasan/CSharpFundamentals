using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(' ')
                .ToList();
                
            string command;
            while((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command.Split(' ');  
                string commandType = cmdArgs[0];
                
                if (commandType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    
                    FixInvalidIndexes(words, ref startIndex, ref endIndex);
                    MergeWords(words, startIndex, endIndex);
                }
                else if (commandType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                    
                    string word = words[index];
                    List<string> partitionsList = DivideWord(word, partitions);
                    
                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);
                }
                
            }
            
            Console.WriteLine(string.Join(" ", words));
        }
        
        static void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            
            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }
            
            if (endIndex < 0)
            {
                endIndex = 0;
            }
                    
            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
        }
        
        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currentWord = words[startIndex];
                mergedText += currentWord;
                words.RemoveAt(startIndex);
            }
            
            words.Insert(startIndex, mergedText);
        }
        
        static List<string> DivideWord(string word, int partitions)
        {
            int substringsLength = word.Length / partitions;
            int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);
                    
            List<string> partitionsList = new List<string>();
                    
            for (int i = 0; i < partitions; i++)
            {
                int desireLength = substringsLength;
                if (i == partitions - 1)
                {
                    desireLength = lastSubstringLength;
                }
                        
                char[] newPartitionArr = word
                    .Skip(i * substringsLength)
                    .Take(desireLength)
                    .ToArray();
                        
                string newPartition = String.Join("", newPartitionArr);  
                partitionsList.Add(newPartition);
            }
                    
            return partitionsList;
        }
    }
}

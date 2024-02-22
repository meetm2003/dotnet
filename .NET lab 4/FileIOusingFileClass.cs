using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork.NET_lab_4
{
    internal class FileIOusingFileClass
    {
            static void Main()
            {
                // Example file path
                string filePath = "D:\\docs\\sem 6\\dotnet\\LabWork\\.NET lab 4\\example.txt";

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File exists.");

                    // Read the contents of the file into a string
                    string fileContent = File.ReadAllText(filePath);
                    Console.WriteLine($"File content:\n{fileContent}");

                    // Append new lines to the file
                    string[] newLines = { "This is a new line.", "Another new line." };
                    File.WriteAllLines(filePath, newLines);

                    Console.WriteLine("New lines appended to the file.");
                }
                else
                {
                    Console.WriteLine("File does not exist. Creating a new file.");

                    // Create a new file and write lines to it
                    string[] lines = { "Hello, world!", "This is a new file." };
                    File.WriteAllLines(filePath, lines);

                    Console.WriteLine("New file created with content.");
                }
            }
        }

    }

using System;
using System.IO;

namespace CharInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            recFun();
            void recFun()
            { 
                try
                {
                    Console.WriteLine("Please enter the path eg ./textFile.txt");
                    string filePath = Console.ReadLine();
                    Console.WriteLine("Enter the sequence or character you wish to find and replace.");
                    string textToChange = Console.ReadLine();
                    Console.WriteLine("Enter the replacement text for the given sequence.");
                    string textToAdd = Console.ReadLine();
                    responseFun();
                    void responseFun()
                    {
                        Console.WriteLine("You want to replace all insances of {0} with {1} correct? yes/no", textToChange, textToAdd);
                        string response = Console.ReadLine();
                        if (response == "yes")
                        {
                            string text = File.ReadAllText(filePath);
                            text = text.Replace(textToChange, textToAdd);
                            File.WriteAllText(filePath, text);
                            Console.Clear();
                            Console.WriteLine("Success !");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            recFun();
                        }
                        else if (response == "no")
                        {
                            Console.WriteLine("Changes Aborted.");
                            Console.Clear();
                            recFun();                         
                        }
                        else if (response != "yes" && response != "no")
                        {
                            Console.WriteLine("That is not a valid response please answer yes or no");
                            responseFun();
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong, please ensure the file is placed in the correct directory, and check spelling.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    recFun();
                }
            }
        }
    }
}

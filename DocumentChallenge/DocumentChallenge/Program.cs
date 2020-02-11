using System;
using System.IO;
using System.Reflection;

namespace DocumentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "y";
            while(loop.ToLower() == "y")
            {
                try
                {
                    Console.WriteLine("Document");

                    Console.Write("Enter a name for the document: ");
                    var name = Console.ReadLine();
                    if (!name.EndsWith(".txt"))
                    {
                        name = $"{name}.txt";
                    }

                    Console.Write("Enter the document contents: ");
                    var content = Console.ReadLine();
                    var path = $"{Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName)}\\{name}";
                    File.WriteAllText(path, content);

                    Console.WriteLine($"{name} was successfully saved. The document contains {content.Length} characters.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.Write("Would you like to save another document? (y/n)");
                    loop = Console.ReadLine();
                }
            }
            
            
        }
    }
}

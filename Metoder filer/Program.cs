using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metoder_filer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Opgave 1
            File.WriteAllText(@".\StarWars.txt", "Han skød først"); */
            /*opgave 2
            string read = File.ReadAllText(@".\StarWars.txt");
            Console.WriteLine(read);*/
            /*opgave 3
            File.Delete(@".\StarWars.txt");*/
            /*Opgave 4
            Directory.CreateDirectory(@".\Droids");*/
            /*Opgave 5
            Directory.CreateDirectory(@".\Droids");
            File.WriteAllText(@".\Droids\R2D2.txt", "beep bop");
            Directory.Delete(@".\Droids", true);*/
            /*Opgave 6
            Directory.CreateDirectory(@".\Droids\Astromech");
            Directory.CreateDirectory(@".\Droids\Protocol");
            File.WriteAllText(@".\Droids\Astromech\R2D2.txt", "beep bop");
            File.WriteAllText(@".\Droids\Protocol\C3P0.txt", "sir!");

            string[] file = Directory.GetFiles(@".\Droids", "*", SearchOption.AllDirectories);

            foreach (string s in file)
            {
                Console.WriteLine(s);
            }*/
            /*læs fra fil
            File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi\n");

            FileStream file = new FileStream(@".\Movies.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string movie = reader.ReadLine();
                Console.WriteLine(movie);
            }
            file.Close();
            reader.Close();*/
            /*skriv til fil
            List<string> actors = new List<string>()
            {
                "Mark Hamill",
                "Harrison Ford",
                "Carrie Fisher"
            };

            FileStream file = new FileStream(@".\Actors.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file))

            foreach (string s in actors)
            {
                writer.WriteLine(s);
                Console.WriteLine(s);
            }*/
            //Opgave 7
            Console.Write("1. Add file\n2. Delete file\n3. Display files\n4. Add folder\n5. Searh for file in folder\n6. Exit\n\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddFile();
                    break;
                case 2:
                    DeleteFile();
                    break;
                case 3:
                    DisplayFile();
                    break;
                case 4:
                    AddFolder();
                    break;
                case 5:
                    SearchForFileInFolder();
                    break;
                case 6:
                    break;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        public static void AddFile()
        {
            Console.Write("Insert the name of the file you want to create:");
            string fileName = Console.ReadLine();

            File.Create(@".\" + fileName);
        }
        public static void DeleteFile()
        {
            Console.Write("Insert the name of the file to delete:");
            string fileName = Console.ReadLine();

            File.Delete(@".\" + fileName);
        }
        public static void DisplayFile()
        {
            Console.Write("Insert the name of the file you want to display:");
            string fileName = Console.ReadLine();

            string read = File.ReadAllText(@".\" + fileName);
            Console.WriteLine(read);
        }
        public static void AddFolder()
        {
            Console.Write("Insert the name of the folder you want to create:");
            string folderName = Console.ReadLine();

            Directory.CreateDirectory(@".\" + folderName);
        }
        public static void SearchForFileInFolder()
        {
            Console.Write("Insert the name of the folder you want to search:");
            string folderName = Console.ReadLine();
            
            string[] file = Directory.GetFiles(@".\" + folderName, "*", SearchOption.AllDirectories);

            foreach (string s in file)
            {
                Console.WriteLine(s);
            }
        }
    }
}

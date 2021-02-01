using System;

namespace HW_1._1_30_01_21
{
    class Program
    {
    const string pro = "licensePro";
    const string exp = "licenseExp";
        static void Main(string[] args)
        {
            Console.Write("Вводите ключь лицензии: ");
            string License = Console.ReadLine();
            DocumentWorker worker;
            switch (License)
            {
                case pro: worker = new ProDocumentWorker(); break;
                case exp: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }
            while (true)
            {
                Console.WriteLine("\nВведите команду(Open\nEdit\nSave\nExit): ");
                switch (Console.ReadLine())
                {
                    case "Open": worker.OpenDocument(); break;
                    case "Edit": worker.EditDocument(); break;
                    case "Save": worker.SaveDocument(); break;
                    case "Exit": return;
                }
            }
        }
    }
}

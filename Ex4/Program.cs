using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ: ");
            string key = Console.ReadLine();

            DocumentWorker doc = null;

            switch (key)
            {
                case "pro": doc = new ProDocumentWorker(); break;
                case "exp": doc = new ExpertDocumentWorker(); break;
                default: doc = new DocumentWorker();
                    break;
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
            Console.ReadLine();
        }
    }
}

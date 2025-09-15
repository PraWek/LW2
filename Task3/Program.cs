using System;

// Основная программа
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ключ доступа (pro/exp) или нажмите Enter для бесплатной версии:");
        string key = Console.ReadLine();

        DocumentWorker documentWorker;

        // Создаем экземпляр соответствующей версии
        if (key == "pro")
        {
            documentWorker = new ProDocumentWorker();
            Console.WriteLine("Активирована PRO версия");
        }
        else if (key == "exp")
        {
            documentWorker = new ExpertDocumentWorker();
            Console.WriteLine("Активирована EXPERT версия");
        }
        else
        {
            documentWorker = new DocumentWorker();
            Console.WriteLine("Активирована бесплатная версия");
        }

        Console.WriteLine("\nДемонстрация функционала:");
        Console.WriteLine();

        // Демонстрируем функционал
        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
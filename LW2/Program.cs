using System;

// Пример использования
class Program
{
    static void Main()
    {
        Console.WriteLine("Класс с 4 учениками:");
        ClassRoom class1 = new ClassRoom(
            new ExcelentPupil(),
            new GoodPupil(),
            new BadPupil(),
            new ExcelentPupil()
        );
        class1.ShowClassInfo();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Класс с 3 учениками (автоматически добавлен хорошист):");
        ClassRoom class2 = new ClassRoom(
            new ExcelentPupil(),
            new GoodPupil(),
            new BadPupil()
        );
        class2.ShowClassInfo();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Класс с 2 учениками (автоматически добавлены 2 хорошиста):");
        ClassRoom class3 = new ClassRoom(
            new ExcelentPupil(),
            new BadPupil()
        );
        class3.ShowClassInfo();
    }
}
using System;

// Класс учебного класса
public class ClassRoom
{
    private Pupil[] pupils;

    // Конструктор с использованием params для произвольного количества учеников
    public ClassRoom(params Pupil[] pupils)
    {
        // Если передано меньше 4 учеников, дополняем массив до 4
        if (pupils.Length < 4)
        {
            this.pupils = new Pupil[4];
            Array.Copy(pupils, this.pupils, pupils.Length);

            // Заполняем оставшиеся места хорошистами
            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new GoodPupil();
            }
        }
        else
        {
            this.pupils = pupils;
        }
    }

    // Метод для вывода информации о всех учениках
    public void ShowClassInfo()
    {
        Console.WriteLine("Информация о классе");

        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"\nУченик {i + 1}");
            Console.Write("Учеба: "); pupils[i].Study();
            Console.Write("Чтение: "); pupils[i].Read();
            Console.Write("Письмо: "); pupils[i].Write();
            Console.Write("Отдых: "); pupils[i].Relax();
        }
    }
}
using System;

// Программа для демонстрации
class Program
{
    static void Main()
    {
        // Создаем различные транспортные средства
        Vehicle[] vehicles = new Vehicle[]
        {
            new Plane(55.7558, 37.6173, 50000000m, 900, 2020, 10000, 180),
            new Car(59.9343, 30.3351, 2500000m, 220, 2022),
            new Ship(43.5853, 39.7203, 120000000m, 50, 2018, 2000, "Сочи"),
            new Plane(40.7128, -74.0060, 75000000m, 850, 2021, 11000, 250),
            new Ship(44.8950, 37.3163, 85000000m, 40, 2020, 1200, "Анапа")
        };

        // Выводим информацию о всех транспортных средствах
        Console.WriteLine("Информация о транспортных средствах");
        Console.WriteLine();

        foreach (var vehicle in vehicles)
        {
            vehicle.PrintInfo();
        }

        // Демонстрация работы с конкретными типами
        Console.WriteLine("Дополнительная информация");
        Console.WriteLine();

        foreach (var vehicle in vehicles)
        {
            if (vehicle is Plane plane)
            {
                Console.WriteLine($"Самолет: высота {plane.Altitude}м, {plane.Passengers} пассажиров");
            }
            else if (vehicle is Ship ship)
            {
                Console.WriteLine($"Корабль: порт {ship.HomePort}, {ship.Passengers} пассажиров");
            }
            else if (vehicle is Car car)
            {
                Console.WriteLine($"Автомобиль: скорость {car.Speed} км/ч, цена {car.Price:C}");
            }
        }
    }
}
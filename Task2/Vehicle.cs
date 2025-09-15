using System;

// Базовый класс Vehicle
public class Vehicle
{
    // Поля координат
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    // Параметры средства передвижения
    public decimal Price { get; set; }
    public double Speed { get; set; }
    public int Year { get; set; }

    // Конструктор базового класса
    public Vehicle(double latitude, double longitude, decimal price, double speed, int year)
    {
        Latitude = latitude;
        Longitude = longitude;
        Price = price;
        Speed = speed;
        Year = year;
    }

    // Виртуальный метод для вывода информации
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Координаты: {Latitude}, {Longitude}");
        Console.WriteLine($"Цена: {Price:C}");
        Console.WriteLine($"Скорость: {Speed} км/ч");
        Console.WriteLine($"Год выпуска: {Year}");
    }
}

// Класс Plane
public class Plane : Vehicle
{
    public double Altitude { get; set; }
    public int Passengers { get; set; }

    // Конструктор с вызовом базового конструктора
    public Plane(double latitude, double longitude, decimal price, double speed, int year,
                double altitude, int passengers)
        : base(latitude, longitude, price, speed, year)
    {
        Altitude = altitude;
        Passengers = passengers;
    }

    // Переопределение метода вывода информации
    public override void PrintInfo()
    {
        Console.WriteLine("Самолет");
        base.PrintInfo();
        Console.WriteLine($"Высота полета: {Altitude} м");
        Console.WriteLine($"Количество пассажиров: {Passengers}");
        Console.WriteLine();
    }
}

// Класс Car
public class Car : Vehicle
{
    // Конструктор с вызовом базового конструктора
    public Car(double latitude, double longitude, decimal price, double speed, int year)
        : base(latitude, longitude, price, speed, year)
    {
    }

    // Переопределение метода вывода информации
    public override void PrintInfo()
    {
        Console.WriteLine("Автомобиль");
        base.PrintInfo();
        Console.WriteLine();
    }
}

// Класс Ship
public class Ship : Vehicle
{
    public int Passengers { get; set; }
    public string HomePort { get; set; }

    // Конструктор с вызовом базового конструктора
    public Ship(double latitude, double longitude, decimal price, double speed, int year,
               int passengers, string homePort)
        : base(latitude, longitude, price, speed, year)
    {
        Passengers = passengers;
        HomePort = homePort;
    }

    // Переопределение метода вывода информации
    public override void PrintInfo()
    {
        Console.WriteLine("Корабль");
        base.PrintInfo();
        Console.WriteLine($"Количество пассажиров: {Passengers}");
        Console.WriteLine($"Порт приписки: {HomePort}");
        Console.WriteLine();
    }
}
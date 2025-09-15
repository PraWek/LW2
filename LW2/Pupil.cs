using System;

// Базовый класс ученика
public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает");
    }
}

// Отличник
public class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник усердно учится");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает быстро и внимательно");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет аккуратно и грамотно");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает умеренно");
    }
}

// Хорошист
public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хорошист старательно учится");
    }

    public override void Read()
    {
        Console.WriteLine("Хорошист читает внимательно");
    }

    public override void Write()
    {
        Console.WriteLine("Хорошист пишет грамотно");
    }

    public override void Relax()
    {
        Console.WriteLine("Хорошист любит отдыхать");
    }
}

// Двоечник
public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Двоечник не любит учиться");
    }

    public override void Read()
    {
        Console.WriteLine("Двоечник читает медленно и с ошибками");
    }

    public override void Write()
    {
        Console.WriteLine("Двоечник пишет неаккуратно и с ошибками");
    }

    public override void Relax()
    {
        Console.WriteLine("Двоечник обожает отдыхать");
    }
}
using System;
using System.Collections.Generic;

// Базовий клас для живих організмів
public class ЖивийОрганізм
{
    public int Енергія { get; set; }
    public int Вік { get; set; }
    public double Розмір { get; set; }
}

// Спадкоємні класи для тварин, рослин і мікроорганізмів
public class Тварина : ЖивийОрганізм, IPredator, IReproducible
{
    public string Вид { get; set; }

    public Тварина(string вид)
    {
        Вид = вид;
    }

    public void Полювати()
    {
        // Реалізація полювання
    }

    public void Розмножуватися()
    {
        // Реалізація розмноження
    }
}

public class Рослина : ЖивийОрганізм, IReproducible
{
    public string Вид { get; set; }

    public Рослина(string вид)
    {
        Вид = вид;
    }

    public void Розмножуватися()
    {
        // Реалізація розмноження
    }
}

public class Мікроорганізм : ЖивийОрганізм, IReproducible
{
    public string Вид { get; set; }

    public Мікроорганізм(string вид)
    {
        Вид = вид;
    }

    public void Розмножуватися()
    {
        // Реалізація розмноження
    }
}

// Інтерфейси для розмноження і полювання
public interface IReproducible
{
    void Розмножуватися();
}

public interface IPredator
{
    void Полювати();
}

// Клас для моделювання екосистеми
public class Екосистема
{
    public List<ЖивийОрганізм> Організми { get; set; }

    public Екосистема()
    {
        Організми = new List<ЖивийОрганізм>();
    }

    public void МоделюватиВзаємодію()
    {
        // Реалізація взаємодії між організмами в екосистемі
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Ваш код для тестування класів тут
    }
}

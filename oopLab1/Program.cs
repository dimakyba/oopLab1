// See https://aka.ms/new-console-template for more information

// 1.
// Реалізувати клас, що представляє арифметичну прогресію. Передбачити індексатор
// для одержання i -го члена прогресії, методи введення/виведення, 
// знаходження
// // суми n членів цієї прогресії.

// 2.
// Варіант 8.
// 1. Описати клас, який містять вказані поля і методи.
// Клас “коло” – TCircle
// Поля  для зберігання радіуса;
// Методи  конструктор без параметрів, конструктор з параметрами, конструктор копіювання;

//  override public string ToString();
//  введення/виведення даних;
//  визначення площі круга (обмеженого колом), площі сектора (кут є параметром);
//  визначення довжини кола;
//  порівняння з іншим колом;
//  перевантаження операторів + (додавання радіусів), – (віднімання радіусів; при
// від’ємному результаті брати за модулем), * (множення радіуса на число; забезпечити, щоб
// домноження могло відбуватися хоч як «число*коло», хоч як «коло*число»).
// 2. Створити клас-нащадок TSphere (сфера) на основі класу TCircle. Додати метод
// знаходження об’єму кулі (обмеженої сферою) та перевизначити відповідні методи.
// 3. Створити програму-клієнт для тестування.


// class Program
// {
//     static void Main(string[] args)
//     {
//         ArithmeticProgression gaysex = new();

        
//     }
// }


// class ArithmeticProgression
// {
//     int firstElement;
//     int difference;
//     int amount;
//     int sumOfSequence;

//     public ArithmeticProgression(int firstElement, int difference, int amount)
//     {
//         this.firstElement = firstElement;
//         this.difference = difference;
//         this.amount = amount;
//     }
//     public ArithmeticProgression()
//     {
//         this.firstElement =0;
//         this.difference = 0;
//         this.amount = 0;
        
//     }

//     int SumOfSequence(int firstElement, int difference, int amount) {
//         return (firstElement*2 + difference*(amount-1))/2*amount;
//     }


//     public int this[int index] {

//     }


// }



using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкт арифметичної прогресії через конструктор з параметрами
        ArithmeticProgression progression = new ArithmeticProgression(5, 3, 10);

        // Виведення перших 10 членів прогресії
        Console.WriteLine("Арифметична прогресія:");
        for (int i = 0; i < progression.Amount; i++)
        {
            Console.Write(progression[i] + " ");
        }
        Console.WriteLine();

        // Виведення суми перших 10 членів прогресії
        Console.WriteLine($"\nСума перших {progression.Amount} членів прогресії: {progression.SumOfSequence()}");
    }
}

class ArithmeticProgression
{
    private int firstElement;   // Перший член прогресії
    private int difference;     // Різниця між членами прогресії
    private int amount;         // Кількість членів прогресії

    // Властивості для доступу до полів
    public int FirstElement
    {
        get { return firstElement; }
        set { firstElement = value; }
    }

    public int Difference
    {
        get { return difference; }
        set { difference = value; }
    }

    public int Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    // Конструктор з параметрами
    public ArithmeticProgression(int firstElement, int difference, int amount)
    {
        this.firstElement = firstElement;
        this.difference = difference;
        this.amount = amount;
    }

    // Конструктор за замовчуванням
    public ArithmeticProgression()
    {
        this.firstElement = 0;
        this.difference = 0;
        this.amount = 0;
    }

    // Індексатор для доступу до i-го члена прогресії
    public int this[int index]
    {
        get
        {
            // Формула для обчислення i-го члена арифметичної прогресії
            return firstElement + index * difference;
        }
    }

    // Метод для обчислення суми n членів прогресії
    public int SumOfSequence()
    {
        return (amount * (2 * firstElement + (amount - 1) * difference)) / 2;
    }
}

/// <summary>
/// Метод сравнение сущностей из первого массива и записи удовлетворяющих сущностей во второй массив
/// </summary>
/// <param name="array1"> массив с исходными данными ТЗ </param>
/// <param name="array2"> новый массив, куда будут записываться данные, удовлетворяющие ТЗ</param>
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

/// <summary>
/// Метод вывода на экран получившихся данных
/// </summary>
/// <param name="array"> массив, который содержит данные, удовлетворяющие ТЗ</param>
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Тело программы, которое видит пользователь - обращение к пользователю 
System.Console.WriteLine();
System.Console.WriteLine("Добрый день, уважаемый пользователь!");
System.Console.WriteLine("Перед Вами программа, которая может из имеющегося массива строк сформировать массив из строк, длина которых не превышает 3-х символов.");
System.Console.WriteLine();

// Тело программы, которое видит пользователь - описание условия решения задачи в ТЗ 
System.Console.WriteLine("PS: в связи с тем, что ТЗ на работу сформировано весьма условно (разработчик сам выбирает, как появляются данные в массиве - они вводятся пользователем или появляются на старте заранее), был выбран самый простой вариант:");
System.Console.WriteLine("в качестве данных для проверки заранее заданы данные из ТЗ:");
System.Console.WriteLine("hello, 2, world, :-), 1234, 1567, -2, computer science, Russia, Denmark, Kazan");
System.Console.WriteLine();

string[] array1 = new string[11] { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" }; // Запись в массив данных из ТЗ
string[] array2 = new string[array1.Length]; // Создание массива, который будет содержать данные, удовлетворяющие ТЗ

// Тело программы, которое видит пользователь - анонисрование решения 
System.Console.WriteLine("Как итог, программа после запуска выдаст вот такие данные:");
System.Console.WriteLine();

SecondArray(array1, array2);
PrintArray(array2);

// Тело программы, которое видит пользователь - благодарность за использование программы  
Console.WriteLine();
System.Console.WriteLine("Спасибо, что запустили программу!");
using System;
enum Hero { Воин, Маг, Вор }
enum TimeOfDay { Утро, День, Вечер, Ночь }
enum TrafficLight { Red, Yellow, Green }
enum ORstate { New, Processing, Shipped, Delivered }

internal class Program
{
    static void Main(string[] args)
    {
        ///*
        //for(действие до выполнения;условие;действие после выполнения цикла) {
        //    тело цикла
        //}
        //*/
        ////for (int i = 0, j = 0; i < 10; i++, j++)
        ////{
        ////    Console.WriteLine($"{i*j}");
        ////}

        ////int sum = 0;
        ////for (int i = 1; i <= 10; i++)
        ////{
        ////    sum += i;
        ////}
        ////Console.WriteLine(sum);

        ////int i = 10;
        ////while(i > 0)
        ////{
        ////    Console.WriteLine(i);
        ////    i--;
        ////}

        //int j = -1;
        //do
        //{
        //    Console.WriteLine(j);
        //    j--;
        //}
        //while(j > 0);

        //string text = "hello world";
        //foreach(var symbol in text)
        //{
        //    Console.WriteLine(symbol);
        //}

        //for (int i = 1; i < 10; i ++)
        //{
        //    for (int j = 1; j < 10; j++)
        //    {
        //        Console.WriteLine($"{i * j} \t");
        //    }
        //    Console.WriteLine();
        //}

        ///*
        //Console.ForegroundColor = ConsoleColor.Yellow;
        //Console.WriteLine("введите фразы для повторения или 'выход'");
        //while (true)
        //{ Console.Write("> ");
        //    string us = Console.ReadLine();
        //    ().ToLower();
        //    if (us == "выход") break;
        //    Console.WriteLine(us);
        //}
        //int number = 10;
        //DayOfWeek day = DayOfWeek.Суббота;   
        //Console.WriteLine((int)day);
        //switch (day)
        //{
        //    case DayOfWeek.Суббота:
        //    case DayOfWeek.Воскресенье:
        //        Console.WriteLine("Выходной");
        //            break; 
        //    default:
        //        Console.WriteLine("Будний день");
        //            break;
        //}
        //enum DayOfWeek
        //{
        //    Понедельник = 1, Вторник, Среда = 2, Четверг = 2, Пятница, Суббота, Воскресенье
        //}

        //задание 10
        // Мини-проект с героями
        //var times = Enum.GetValues(typeof(TimeOfDay));
        //var heroes = Enum.GetValues(typeof(Hero));

        //for (int i = 0; i < times.Length; i++)
        //{
        //    TimeOfDay time = (TimeOfDay)times.GetValue(i);
        //    Console.WriteLine($"\nВремя сейчас {time}:");

        //    for (int j = 0; j < heroes.Length; j++)
        //    {
        //        Hero h = (Hero)heroes.GetValue(j);
        //        Console.Write($"{h} - ");

        //        switch (time)
        //        {
        //            case TimeOfDay.Утро:
        //                Console.WriteLine(h switch
        //                {
        //                    Hero.Воин => "делает зарядку",
        //                    Hero.Маг => "заваривает зелья",
        //                    Hero.Вор => "крадётся по базару",
        //                    _ => "ничего не делает"
        //                });
        //                break;
        //            case TimeOfDay.День:
        //                Console.WriteLine(h switch
        //                {
        //                    Hero.Воин => "тренируется на арене",
        //                    Hero.Маг => "изучает древние книги",
        //                    Hero.Вор => "прячется в тенях",
        //                    _ => "ничего не делает"
        //                });
        //                break;
        //            case TimeOfDay.Вечер:
        //                Console.WriteLine(h switch
        //                {
        //                    Hero.Воин => "ест мясо у костра",
        //                    Hero.Маг => "создаёт магический щит",
        //                    Hero.Вор => "планирует налет",
        //                    _ => "ничего не делает"
        //                });
        //                break;
        //            case TimeOfDay.Ночь:
        //                Console.WriteLine(h switch
        //                {
        //                    Hero.Воин => "спит в палатке",
        //                    Hero.Маг => "медитирует под луной",
        //                    Hero.Вор => "лезет в чужой дом",
        //                    _ => "ничего не делает"
        //                });
        //                break;
        //        }
        //    }

        //1
        //TrafficLight current = TrafficLight.Green;
        //TrafficLight next = current switch
        //{
        //    TrafficLight.Red => TrafficLight.Yellow,
        //    TrafficLight.Yellow => TrafficLight.Green,
        //    TrafficLight.Green => TrafficLight.Red,
        //    _ => current
        //};
        //Console.WriteLine($"Текущий свет: {current}, Следующий: {next}");
        //Console.WriteLine("---");

        ////2
        //bool canOR(ORstate status) =>
        //    status == ORstate.New || status == ORstate.Processing;

        //Console.WriteLine($"New: {canOR(ORstate.New)}");
        //Console.WriteLine($"Processing: {canOR(ORstate.Processing)}");
        //Console.WriteLine($"Shipped: {canOR(ORstate.Shipped)}");
        //Console.WriteLine($"Delivered: {canOR(ORstate.Delivered)}");
        //Console.WriteLine("---");

        ////3
        //for (int i = 10; i >= 1; i--)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine("---");
        ////4
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"5 * {i} = {5 * i}");
        //}
        //Console.WriteLine("---");

        ////5
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
        //}
        //Console.WriteLine("---");

        ////6
        //for (int i = 0; i <= 5; i++)
        //{
        //    Console.WriteLine($"{i} в квадрате = {i * i}");
        //}
        //Console.WriteLine("---");

        ////7
        //string sentence = "Hello";
        //for (int i = 0; i < 3; i++)
        //{
        //    Console.WriteLine(sentence);
        //}
        //Console.WriteLine("---");

        ////8
        //int[] numbers = { 2, 4, 6, 8, 10 };
        //bool allEven = true;

        //foreach (int number in numbers)
        //{
        //    if (number % 2 != 0)
        //    {
        //        allEven = false;
        //        break;
        //    }
        //}
        //Console.WriteLine(allEven ? "YES" : "NO");
        //Console.WriteLine("---");

        ////9

        //int shot = 0;

        //for (int i = 1; i <= 3; i++)
        //{
        //    Console.WriteLine("Выстрел совершен");
        //    shot++;
        //    Console.WriteLine($"Израсходовано боезапасов: {shot}");

        //    if (i < 3)
        //    {
        //        Console.Write("Введите 'Стоп' для остановки или Enter для продолжения: ");
        //        string input = Console.ReadLine();

        //        if (input?.ToLower() == "стоп")
        //        {
        //            Console.WriteLine("Огонь прекращен!");
        //            break;

        //4 ЛАБААААА







        //int[] number = [12, 23, 45, 56];
        //int[] num = { 12, 23, 45, 56 };
        //int[] number3 =new int[] { 12, 23, 45, 56 };
        //int[] number4 = new int[4] { 12, 23, 45, 56 };
        //int[] number5 = new [] { 12, 23, 45, 56 };
        //foreach (var i in number)
        //{
        //    Console.WriteLine(i);
        //}
        //number[0] = 345;
        //Console.WriteLine(number.Length);
        //Console.WriteLine(number3[^1]);


        //dynamic[] text1 = [3, 4, 5, 6.4, 'd', "text"];
        //object[] text2 = [3, 4, 5, 6.4, 'd', "text"];

        //List<string> people = ["Денис", "Диман", "Иван"];
        //List<string> people2 = new List<string>  {"Денис", "Диман", "Иван"};
        //Console.WriteLine(people.Count);
        //people.Add("Андрей");
        //people.Clear();
        //people.Insert(0, "");
        //people.Remove("Богдан");
        //people.RemoveAt(0);

        //int[] numbers = [-1, -2, -3, 4, 5, 6, 8, 43, 56, 34, 12, 45, 102, 76, -45, 96, -4, -3, 5, 76, 6, 8, 2, 8, 5, 9];
        //int result = 0;
        ////int i = 0;

        //while (i < numbers.Length)
        //{
        //    if (numbers[i] > 0)
        //        result++;
        //    i++;
        //}

        //Console.WriteLine($"Число элементов больше нуля (while): {result}");

        //result = 0;

        //for (int j = 0; j < numbers.Length; j++)
        //{
        //    if (numbers[j] > 0)
        //        result++;
        //}

        //Console.WriteLine($"Число элементов больше нуля (for): {result}");




        //int n = numbers.Length;
        //int k = n / 2;
        //int temp;
        //for (int i = 0; i < k; i++)
        //{
        //    temp = numbers[i];
        //    numbers[i] = numbers[n - i - 1];
        //    numbers[n - i - 1] = temp;
        //}
        //foreach (int i in numbers)
        //{
        //    Console.Write($"{i} \t");
        //}


        //int[] nums = {54, 7, 41, 2, 4, 2, 89, 33, 5, 12};
        //int temp;
        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    for (int j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] > nums[j])
        //        {
        //            temp = nums[i];
        //            nums[i] = nums[j];
        //            nums[j] = temp;
        //        }
        //    }

        //}
        //Console.WriteLine("Вывод отсортированного массива:");
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    Console.WriteLine(nums[i]);
        //}





        //List<string> student = ["Билли", "Игорь", "Степан"];
        //string firstStudent = student[0];
        //// получаем первый элемент
        //Console.WriteLine(firstStudent); // Билли
        //student[0] = "Богдан"; // изменяем первый элемент
        //Console.WriteLine(student[0]); // Богдан


        //List<string> student = ["Билли", "Игорь", "Степан"];
        //foreach (var person in student)
        //{
        //    Console.WriteLine(person);
        //}


        //List<string> student = ["Билли", "Игорь", "Степан"];
        //student.Add("Van"); // добавление нового элемента в список
        //student.AddRange(["Антон", "Денис"]);
        //student.Insert(1, "Кирилл"); // вставляет элемент item в список по индексу index
        //student.InsertRange(1, ["Mike", "Kate"]); // вставляет коллекцию элементов
        //                                          // начиная с индекса index
        //student.Insert(7, "Михаил"); // вставляет элемент item в список по индексу index
        //foreach (var person in student)
        //{
        //    Console.WriteLine(person);
        //}
        //var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
        //people.RemoveAt(1); // удаляем второй элемент
        //people.Remove("Tom"); // удаляем элемент: "Том"
        //people.RemoveRange(1, 2);
        //people.Clear();

        //ДЗ
        //1
        //string[] items = { "sword", "shield", "potion", "sword", "potion", "potion" };
        //foreach (string item in items)
        //{
        //    Console.WriteLine(item);
        //}

        //2
        //int[] s = { 10, 20, 15, 30, 25 };
        //int total = 0;
        //foreach (int i in s)
        //{
        //    total += i;
        //}
        //Console.WriteLine("Общее количество очков: " + total);

        //3
        //int[] numbers = { 1, 3, 7, 2, 5 };
        //int max = numbers[0];

        //foreach (int number in numbers)
        //{
        //    if (number > max)
        //    {
        //        max = number;
        //    }
        //}

        //Console.WriteLine("Максимальный элемент: " + max);
        //4
        //int[] nums = { 1, 2, 3, 4, 5 };
        //int ev = 0;
        //int od = 0;

        //foreach (int num in nums)
        //{
        //    if (num % 2 == 0)
        //        ev++;
        //    else
        //        od++;
        //}

        //Console.WriteLine($"Чётных: {ev}, Нечётных: {od}");
        //5
        //int[] times = { 120, 95, 110, 105, 100 };
        //int fast = times[0];

        //foreach (int time in times)
        //{
        //    if (time < fast)
        //    {
        //        fast = time;
        //    }
        //}

        //Console.WriteLine("Самое быстрое время: " + fast + " секунд");
        //6
        //string[] resultatt = ["win", "loss", "win", "win", "loss"];
        //int wins = resultatt.Count(r => r == "win");
        //int losses = resultatt.Count(r => r == "loss");
        //Console.WriteLine($"Результаты игр: [{string.Join(", ", resultatt)}]");
        //Console.WriteLine($"Итог: {wins} побед и {losses} поражений\n");
        //7
        //int[] igrok = [15, 20, 25, 30, 10];
        //double avg = igrok.Average();
        //Console.WriteLine($"Очки за игры: [{string.Join(", ", igrok)}]");
        //Console.WriteLine($"Среднее количество очков: {avg}\n");








    }
}














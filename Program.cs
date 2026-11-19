// Console.Write("Сколько студентов в группе?");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}:");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// foreach(int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;

// }
// Console.WriteLine($"Средняя оценка группы: {(double)sum / studentsCount}");



// int[] points = { 4, 7, 2, 11, 5 };

// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }


// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }

// foreach(int grade in grades)
// {
//     Console.WriteLine(grade);
// }





// int[] GenerateScheduleSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = i + 1;
//     }

//     return slots;
// }

// int[] GenerateEvenSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = (i + 1) * 2;
//     }

//     return slots;
// }

// // int[] slots = GenerateScheduleSlots(6);

// // foreach (int slot in slots) {
// //     Console.WriteLine(slot);
// // }

// int[] evenSlots = GenerateEvenSlots(6);

// foreach (int slot in evenSlots) {
//     Console.WriteLine(slot);
// }





// // Задача  B
// int[] sortList = {5, 6, 1, 8, 3, 9, 1, 5, 7, 9 };

// for (int i = 0; i < sortList.Length - 1; i++)
// {
//     for (int j = 0; j < sortList.Length - 1 - i; j++)
//     {
//         if (sortList[j] < sortList[j + 1])
//         {
//             int temp = sortList[j];
//             sortList[j] = sortList[j + 1];
//             sortList[j + 1] = temp;
//         }
//     }
// }

// foreach (int list in sortList)
// {
//     Console.WriteLine(list);
// }


// // Задача  Г
// int[] GenerateEvenNumbers(int n)
// {
//     int count = n / 2;
//     int[] result = new int[count];

//     for (int i = 0; i < count; i++)
//     {
//         result[i] = (i + 1) * 2;
//     }

//     return result;
// }

// int[] evens = GenerateEvenNumbers(9);
// foreach(int num in evens)
// {
//     Console.WriteLine(num);
// }



// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");




// // Вариант 2
// int[] list = { 5, 32, 8, 23, 78, 3, 7, 9, 2 };
// for (int i = 0; i < list.Length; i++)
// {
//     if (list[i] % 3 == 0)
//     {
//         list[i] = -1;
//     }
// }

// foreach(int cn in list)
// {
//     Console.WriteLine(cn);
// }


// // Вариант 4
int[] GenerateFibonacci(int n)
{
    int[] fib = new int[n];

    int a = 1;
    int b = 1;

    for (int i = 0; i < n; i++)
    {
        fib[i] = a;
        int next = a + b;
        a = b;
        b = next;
    }
    return fib;
}

int[] result = GenerateFibonacci(10);
foreach(int l in result)
{
    Console.WriteLine(l);
}
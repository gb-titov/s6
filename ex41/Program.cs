//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//-1, -7, 567, 89, 223-> 3


Console.Clear();
Console.WriteLine("Программа для подсчета количества натуральных чисел.");

int[] array = GetArrayFromUserInput();

int naturalNumsCount = CountNaturalNums(array);

Console.WriteLine($"{WriteArrayAsString(array)} -> {naturalNumsCount}");


#region Methods

int CountNaturalNums(int[] arr) => arr.Count(i => i > 0);

string WriteArrayAsString(int[] arr) => $"[{string.Join(", ", arr)}]";

int[] GetArrayFromUserInput()
{
    while (true)
    {
        Console.Write("Введите несколько чисел через запятую: ");
        var userInputStr = Console.ReadLine();

        int[] arr = GetArray(userInputStr);
        if (arr != null) return arr;

        Console.WriteLine("Неверный ввод! Попробуйте снова.");
    }


}

int[] GetArray(string? str)
{
    if (string.IsNullOrEmpty(str) || !str.Contains(','))
    {
        return null;
    }

    var arr = str.Split(",");

    var intArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (!int.TryParse(arr[i], out int r))
        {
            return null;
        }

        intArr[i] = r;
    }

    return intArr;
}

#endregion


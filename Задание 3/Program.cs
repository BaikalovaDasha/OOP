using System.Text.RegularExpressions;

string f = "C:\\Users\\Дарья\\Desktop\\учеба\\2 курс\\1 семестр\\Программирование\\f.txt";
string text;

// Передадим путь к файлу и имя файла конструктору StreamReader
using (StreamReader sr = new StreamReader(f))
{
    // Считывание всех строк файла
    text = sr.ReadToEnd();
}

Console.Write("Введите строку для поиска: ");
string s = Console.ReadLine();
string[] array = text.Split(new char[] { '.', '!', '?' });
string newtext = "";

/* в класс Regex передаётся регулярное выражение для поиска (с игнорированием
регистра*/

Regex regex = new Regex(s, RegexOptions.IgnoreCase);
foreach (string i in array)
{
    // если есть совпадение
    if (regex.IsMatch(i))
    {
        Console.WriteLine("Обнаружено совпадение:");
        Console.WriteLine(i);
        newtext += i;
    }
}

string g = "C:\\Users\\Дарья\\Desktop\\учеба\\2 курс\\1 семестр\\Программирование\\g.txt";

// полная перезапись файла
// false указывает на то, что файл перезаписывается заново
using (StreamWriter writer = new StreamWriter(g, false))
{
    writer.WriteLine($"\t {newtext}");
    Console.WriteLine("Текст занесён в файл 'g.txt'");
}

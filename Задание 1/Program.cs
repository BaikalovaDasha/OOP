Console.WriteLine("Введите текст:");
string text = Console.ReadLine();

Console.WriteLine("Перевёрнутый текст:");
string reversedText = "";
// вывод перевёрнутого текста
for (int i = text.Length - 1; i > 0; i--)
{
    reversedText += text[i];
}
Console.WriteLine(reversedText);


// char[] arr = text.ToCharArray();
// Array.Reverse(arr);
// Console.WriteLine(arr);

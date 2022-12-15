using System.Text.RegularExpressions;

string regul = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.
(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.
(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\.
(25[0-5]|2[0-4][0-9]|[01]?[0-9]?[0-9])\b";

var ipaddress = new string[]
{
    "87.0.204.21",
    "211.90.199.1165",
    "75.149.24542.159",
    "258.356.0.42",
    "1.1.1.1",
    "0.0.0.0",
    "75.149.242.191",
    "75.256.242.191",
};

Console.WriteLine("IP-адреса");
for (int i = 0; i < ipaddress.Length; i++)
{
    if (Regex.IsMatch(ipaddress[i], regul))
    {
        Console.WriteLine(ipaddress[i]);
    }
}

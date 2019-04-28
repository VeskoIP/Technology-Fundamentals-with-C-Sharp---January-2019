using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        Console.WriteLine(ReverseText(text));
    }

    public static string ReverseText(string text)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = text.Length - 1; i >= 0; i--)
        {
            sb.Append(text[i]);
        }

        return sb.ToString();
    }
}
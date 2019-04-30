using System;
using System.Text;

class DecryptingMessage
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int characters = int.Parse(Console.ReadLine());
        char ch = '\0';
        int asciiCh = 0;

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= characters; i++)
        {
            ch = char.Parse(Console.ReadLine());
            asciiCh = (int)ch + key;
            sb.Append((char)asciiCh);
        }

        Console.WriteLine(sb.ToString());
    }
}
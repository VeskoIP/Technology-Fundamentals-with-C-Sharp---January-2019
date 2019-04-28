using System;

class Messages
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        string key = null;
        char[] arr = new char[num];

        for (int i = 0; i < num; i++)
        {
            key = Console.ReadLine();
            switch (key)
            {
                case "2": arr[i] = 'a'; break;
                case "22": arr[i] = 'b'; break;
                case "222": arr[i] = 'c'; break;

                case "3": arr[i] = 'd'; break;
                case "33": arr[i] = 'e'; break;
                case "333": arr[i] = 'f'; break;

                case "4": arr[i] = 'g'; break;
                case "44": arr[i] = 'h'; break;
                case "444": arr[i] = 'i'; break;

                case "5": arr[i] = 'j'; break;
                case "55": arr[i] = 'k'; break;
                case "555": arr[i] = 'l'; break;

                case "6": arr[i] = 'm'; break;
                case "66": arr[i] = 'n'; break;
                case "666": arr[i] = 'o'; break;

                case "7": arr[i] = 'p'; break;
                case "77": arr[i] = 'q'; break;
                case "777": arr[i] = 'r'; break;
                case "7777": arr[i] = 's'; break;

                case "8": arr[i] = 't'; break;
                case "88": arr[i] = 'u'; break;
                case "888": arr[i] = 'v'; break;

                case "9": arr[i] = 'w'; break;
                case "99": arr[i] = 'x'; break;
                case "999": arr[i] = 'y'; break;
                case "9999": arr[i] = 'z'; break;

                case "0": arr[i] = ' '; break;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }
}
using System;

class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string password;
        int count = 0;
        bool check = false;
        int check2 = 0;

        while (check == false)
        {
            password = Console.ReadLine();

            if (username.Length == password.Length)
            {
                for (int i = 0; i < username.Length; i++)
                {
                    check2 = i;

                    if (password[i] != username[username.Length - (i + 1)] && count < 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        count++;
                        break;

                    }
                    else if (password[i] == username[username.Length - (i + 1)] && count < 4)
                    {
                        check = false;
                    }

                    else
                    {
                        Console.WriteLine($"User {username} blocked!");
                        check = true;
                        break;
                    }
                }
            }

            else if (username.Length != password.Length)
            {
                count++;

                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    check = true;
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (check2 == username.Length - 1)
            {
                Console.WriteLine($"User {username} logged in.");
                check = true;
                break;
            }
        }
    }
}
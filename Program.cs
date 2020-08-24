using System;

namespace PasswordGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Password Generator");
            int Continue = 0;
            do
            {
                Console.WriteLine("How long is the password?");
                int PasswordLength = int.Parse(Console.ReadLine());

                char[] Password = new char[PasswordLength];

                Random random = new Random();

                //Password Generator
                for (int i = 0; i < PasswordLength; i++)
                {
                    int firstBranch = random.Next(1, 4);

                    switch (firstBranch)
                    {
                        case 1:
                            Password[i] = (char)random.Next(48, 58);
                            break;
                        case 2:
                            Password[i] = (char)random.Next(63, 91);
                            break;
                        case 3:
                            Password[i] = (char)random.Next(97, 123);
                            break;
                    }
                }

                for (int i = 0; i < PasswordLength; i++)
                {
                    Console.Write(Password[i]);
                }

                Console.WriteLine();

                Console.WriteLine("Do you want to continue?\n1.Yes\n2.No");
                Continue = int.Parse(Console.ReadLine());

            } while (Continue == 1);
        }

    }
}

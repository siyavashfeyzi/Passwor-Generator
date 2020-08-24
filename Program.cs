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

                //insert At sign random in to the password
                //We definitely have an @ in the password
                int atSign = random.Next(0, PasswordLength);
                Password[atSign] = '@';
                for (int i = 0; i < PasswordLength; i++)
                {
                    int firstBranch = random.Next(1, 4);
                    if (i != atSign)
                    {
                        switch (firstBranch)
                        {
                            case 1:
                                Password[i] = (char)random.Next(48, 58);
                                break;
                            case 2:
                                Password[i] = (char)random.Next(65, 91);
                                break;
                            case 3:
                                Password[i] = (char)random.Next(97, 123);
                                break;
                        }
                    }

                }

                // Write Password. 
                var password = new string(Password);
                Console.WriteLine(password);
                
                Console.WriteLine("Do you want to continue?\n1.Yes\n2.No");
                Continue = int.Parse(Console.ReadLine());

            } while (Continue == 1);
        }

    }
}

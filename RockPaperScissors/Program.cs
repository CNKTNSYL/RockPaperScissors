using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Görev : Kullanıcıya seçmek istediği tercihi sorunuz ([r]ock, [p]aper, [s]cissors)
            //2. Görev : Seçimi konrol ediniz
            //3. Görev : Random oluşturunuz
            //Random=0 => bilgisayar seçeneği : taş
            //Random=1 => bilgisayar seçeneği : kağıt
            //Random=2 => bilgisayar seçeneği : makas
            //4. Görev : Kazananı yazdırınız.
            //Tekrar oynamak istiyormusunuz.
            //6. Görev : Skor tutunuz
            //7. Görev : Oyun sürdükçe skoru güncelleyiniz
            int uScore = 0;
            int pcScore = 0;

        start:
            Console.Write("Do you choose rock, paper or scissors (Rock : R / Paper : P / Scissors : S) : ");
            string uChoice = Console.ReadLine();
            while (uChoice != "R" && uChoice != "r" && uChoice != "P" && uChoice != "p" && uChoice != "S" && uChoice != "s")
            {
                Console.Write("Wrong Input! \nDo you choose rock, paper or scissors (Rock : R / Paper : P / Scissors : S) : ");
                uChoice = Console.ReadLine();
            }


            Random pcChoice = new Random();
            int computerChoice = pcChoice.Next(0, 3);
            Console.WriteLine("-----------------");
            if (computerChoice == 0)
            {
                if (uChoice == "R" || uChoice == "r")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Tie");
                }
                else if (uChoice == "P" || uChoice == "p")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win, paper beats rock");
                    uScore++;

                }
                else if (uChoice == "S" || uChoice == "s")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You lose, rock beats scissors");
                    pcScore++;
                }
            }
            else if (computerChoice == 1)
            {
                if (uChoice == "R" || uChoice == "r")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You lose, paper beats rock");
                    pcScore++;
                }
                else if (uChoice == "P" || uChoice == "p")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Tie");
                }
                else if (uChoice == "S" || uChoice == "s")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win, scissors beats paper");
                    uScore++;
                }
            }
            else if (computerChoice == 2)
            {
                if (uChoice == "R" || uChoice == "r")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win, rock beats scissors");
                    uScore++;
                }
                else if (uChoice == "P" || uChoice == "p")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You lose, scissors beats paper");
                    pcScore++;
                }
                else if (uChoice == "S" || uChoice == "s")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Tie");
                }
            }

            Console.Write("Do you want to play again? (Yes : Y) : ");
            string restart = Console.ReadLine();
            if (restart == "Y" || restart == "y")
            {
                Console.Clear();
                Console.Write("User score : " + uScore + " / ");
                Console.WriteLine("Computer score : " + pcScore);
                goto start;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

namespace Dice_games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerpoints = 0;
            
            int PlayerPoints2 = 0;


            while (1==1){


                Console.WriteLine("vill du slå eller stanna");


                string answer = Console.ReadLine();


                if (answer == "stanna")
                {

                    break;
                }

               
                if (answer != "slå")
                {
                    Console.WriteLine("Fel svar vill du fortsätta?");
                    continue;


                }

                Random rand = new Random();
                int randomNumber = rand.Next(1, 7);
                playerpoints += randomNumber; //funkar, player 1
                
                Console.WriteLine(randomNumber);
                Console.WriteLine("du slog = " + randomNumber);
                Console.WriteLine("din poäng är = " + playerpoints);


                Console.WriteLine("Nu är det min tur");


                int RandomNumber2 = rand.Next(1, 7);
                PlayerPoints2 += RandomNumber2;



                Console.WriteLine(RandomNumber2);

                Console.WriteLine("jag slog = " + RandomNumber2);
                Console.WriteLine("min poäng är = " + PlayerPoints2);



                if (playerpoints > 21 )
                {
                    Console.WriteLine("du har florat");
                    break;
                }

                if (PlayerPoints2 > 21)
                {
                    Console.WriteLine("du har vunnit");
                    break;
                    
                }






            }


            if (playerpoints < 21 && playerpoints > PlayerPoints2)
            {
                Console.WriteLine("du har vunnit");
                
            }

            if (PlayerPoints2 < 21 && PlayerPoints2 > playerpoints)
            {
                Console.WriteLine("du har florat");

            }

        }
    }
}

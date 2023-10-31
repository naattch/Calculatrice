using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            int chf1, chf2;
            char op;
            string a;
            //Questions posées au utilisateur.

            do
            {
                Console.WriteLine("Calculette");
                Console.WriteLine("-----------");
                Console.WriteLine();
                Console.WriteLine("Premier chiffre: ");
                //Stockage d'une valeur
                chf1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Deuxième chiffre: ");
                //Stockage d'une deuxième valeur
                chf2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quelle opération vous voulez choisir? : ");
                Console.WriteLine("(+) (-) (*) (/)");
                //stockage de l'opérateur choisi 
                op = Convert.ToChar(Console.ReadLine());

                //Porte d'acces au opérateur choisi par l'utilisateur


                switch (op)
                {

                    case '+':
                        Console.WriteLine(add(chf1, chf2));
                        Console.WriteLine(chf1 + chf2);
                        break;

                    case '-':
                        Console.WriteLine(sub(chf1, chf2));
                        Console.WriteLine(chf1 - chf2);
                        break;

                    case '*':
                        Console.WriteLine(mult(chf1, chf2));
                        Console.WriteLine(chf1 * chf2);
                        break;

                    case '/':
                        Console.WriteLine(divi(chf1, chf2));
                        Console.WriteLine(chf1 / chf2);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }



                Console.WriteLine("Voulez-vous recommencer?");
                Console.WriteLine("Y or N?");
                a = Console.ReadLine();

                if (a == "y")
                {
                    Console.WriteLine("recommencer");
                    Console.Clear();
                }
                else if (a == "n")
                {
                    Console.WriteLine("Touchez une touche pour fermer le programme");
                }
                else
                {
                    Console.WriteLine("Mauvaise touche le programme va se fermer");
                }
                Console.ReadKey();
            }
            while (a == "y");
            return;

        }
        //les methods pour l'addition, soustraction, multiplication, division
        public static int add(int chf1, int chf2)
        {
            int z = chf1 + chf2;
            return z;
        }

        public static int sub(int chf1, int chf2)
        {
            int a = chf1 - chf2;
            return a;
        }
        public static int mult(int chf1, int chf2)
        {
            int y = chf1 * chf2;
            return y;
        }
        public static int divi(int chf1, int chf2)
        {
            int x = chf1 / chf2;
            return x;
        }
    }
}


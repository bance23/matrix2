using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixokfeltoltese
{
    class Matrixok
    {
        public Matrixok()
        {

        }

        public void getMatrixok()
        {
            Console.WriteLine("Szia! Hány sor legyen?");
            int sor = Convert.ToInt32(Console.ReadLine());
            if (sor % 2 == 1 || sor % 2 == 0)
            {

            }
            else
            {
                Console.WriteLine("Nem egész számot adtál meg. Viszlát!");
            }
            Console.WriteLine("Hány oszlop legyen?");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            if (oszlop % 2 == 1 || oszlop % 2 == 0)
            {

            }
            else
            {
                Console.WriteLine("Nem egész számot adtál meg. Viszlát!");
            }

            int[,] array = new int[sor, oszlop];

            int akarja = 1;
            int beirtelemek = 0;

            do
            {
                beirtelemek++;
                Console.WriteLine("Írja be hanyadik sor és oszlopba milyen értéket akar elhelyezni:");
                string haromszam = Console.ReadLine();
                string[] szamok = (haromszam.Split(','));
                int sorbe = Convert.ToInt32(szamok[0]);
                int oszlopbe = Convert.ToInt32(szamok[1]);
                int ertekbe = Convert.ToInt32(szamok[2]);
                array[sorbe - 1, oszlopbe - 1] = Convert.ToInt32(szamok[2]);

                Console.WriteLine("Ha ki akarsz lépni akkor 0,ha folytatni akkor bármilyen más számot adj meg:");
                akarja = Convert.ToInt32(Console.ReadLine());

            } while (akarja != 0);



            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] != 0)
                    {
                        Console.Write("{0}  ", array[j, i]);
                    }
                    else
                    {
                        array[i, j] = -1;
                        Console.Write("{0}  ", array[j, i]);
                    }

                }
                Console.WriteLine("Ennyi elemet töltöttél ki: {0}", beirtelemek);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrixok matrixok = new Matrixok();
            matrixok.getMatrixok();

            Console.ReadKey();
        }
    }
}
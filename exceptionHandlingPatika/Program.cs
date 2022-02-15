using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlingPatika
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Patika.dev'in C# Modülü ders notları */


            /************************************************************************************************/


            /* Exception Handling */

            // try { Hataya sebebiyet verme ihtimali olan kod }

            // catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

            // finally { Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }

            try
            {
                int a = int.Parse(Console.ReadLine());

                int b = int.Parse(Console.ReadLine());

                int c = a + b;

                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }


        }
    }
}

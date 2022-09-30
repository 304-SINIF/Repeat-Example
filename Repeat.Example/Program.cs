using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variables (1.0)

            //int num1;
            //num1 = 3;
            //int num2 = 5;

            #endregion

            #region Operators (2.0)

            // 2.1
            //Console.WriteLine(3 + 4);

            // 2.2
            //int x = 5;
            //x *= 10;

            // 2.3
            //bool b1 = true;
            //bool b2 = false;
            //bool result = b1 || b2;
            //Console.WriteLine(result);

            #endregion

            #region Conditions (3.0)

            // START 3.1
            //int x = 5;
            //int y = 3;
            //if (x > 6)
            //{
            //    Console.WriteLine("X altıdan büyüktür");
            //}
            //else if (x * y != 99)
            //{
            //    Console.WriteLine("Formül geçersiz");
            //}
            //else
            //{
            //    Console.WriteLine("Hiçbir koşula uyum sağlanmadı");
            //}
            // END 3.1

            // START 3.2
            //int x = 5;
            //switch(x)
            //{
            //    case 1:
            //        Console.WriteLine("X = 1");
            //        break;
            //    case 2:
            //    case 3:
            //    case 4:
            //        Console.WriteLine("X 2, 3 ya da 4 değerinderir");
            //        break;
            //    case 5:
            //        Console.WriteLine("X = 5");
            //        break;

            //    default:
            //        Console.WriteLine("X switch ağacındaki hiçbir değerle eşleşmemektedir");
            //        break;
            //}
            // END 3.2
            #endregion

            #region Conversion (4.0)
            // 4.1
            //int i = 5;
            //double d = Convert.ToDouble(i);

            // 4.2
            //string input = Console.ReadLine();
            //double d = double.Parse(input);

            // 4.3
            //bool isParsable = int.TryParse("a5", out int x);

            // 4.4
            //    // 4.4.1
            //int x = 5;
            //string s = x.ToString();
            //Console.WriteLine(x);

            //    // 4.4.2
            //Random r = new Random();
            //Console.WriteLine(r.ToString());

            //    // 4.4.3
            //StringBuilder sb = new StringBuilder();
            //sb.Append("hello, world!");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Try-Catch-Finally (5.0)

            //try
            //{

            //}
            //catch
            //{

            //}

            //// 5.1
            //try
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int y = 10;
            //    Console.WriteLine(y / x);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Girdi bir sayı değildi");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Sıfıra bölünme denemesi yapıldı");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen bir hata oluştu");
            //}

            //// 5.2
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// 5.3
            //try
            //{

            //}
            //catch
            //{

            //}
            //finally
            //{

            //}
            #endregion

            #region Loops (6.0)

            ////6.1

            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}

            ////6.2

            //int i = 0;
            //do
            //{

            //    i++;
            //}
            //while (i < 10);

            //// 6.3
            
            //for (int i = 0; i < 10; i++)
            //{

            //}

            #endregion

            Console.ReadKey();
        }
    }
}

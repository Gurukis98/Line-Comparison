using System;

namespace Line_Comparion_UC_4
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Program objPro = new Program();
            int x1 = 8;
            int x2 = 6;
            int y1 = 4;
            int y2 = 6;
            //condition
            //5==5 is true (equal to)
            //6<3 is false (greater than)
            //8>4 is true (lesser than)

            Console.WriteLine("Line one: " + x1.CompareTo(y1));
            Console.WriteLine("Line Two.: " + x2.CompareTo(y2));
        }
    }
}

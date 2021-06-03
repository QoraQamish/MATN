using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATN
{
    class Program
    {
        static void Main(string[] args)
        {

            Shifrlash shifrlash = new Shifrlash();
            // Saqlash;
            Console.WriteLine("Matn kiriting");
            shifrlash.Save(Console.ReadLine());
            shifrlash.Write();
            string a= shifrlash.Read();
            Console.WriteLine("Matn shiferlash uchun massivni kiriting (,) belgi bilan ajrating");
           
            //---
            string[] arryString =Console.ReadLine().Split(',');
            int[] arry = new int[arryString.Length];
            for (int i = 0; i < arryString.Length; i++)
            {
                arry[i] = int.Parse(arryString[i]);
            }
            //---
            shifrlash = new Shifrlash(a,arry);
            shifrlash.ShifrLogic();

            Console.ReadKey();
        }
    }
}

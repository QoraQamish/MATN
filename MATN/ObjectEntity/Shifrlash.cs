using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATN
{
    public class Shifrlash:MATNC
    {
        public int[] shifr { get; set; }
        public Shifrlash()
        {

        }
        public  Shifrlash(string matn,int[] shifr)
        {
            this.shifr = shifr;
            this.matn = matn;
        }
        public void ShifrLogic()
        {
            int a = 0;
            int len = shifr.Length;
            int j = 0;
            string result = "";

                for (int i = 0; i < matn.Length; i++)
                {
                    a = (int)matn[i] + shifr[j];
                    if((int)matn[i]<=90)
                    {
                        if (a <= 90) { }
                        else
                        {
                            while (true)
                            {
                                a = (a - 90);
                                if (a <= 90) break;
                            }
                            a = a + 65;

                        }
                    }
                    else
                    {
                        if (a <= 122) { }
                        else
                        {
                            while (true)
                            {
                                a = (a - 97);
                                if (a <= 97) break;
                            }
                            a = a + 122;

                        }
                    }
                    result += (char)(a);
                if (len - 1 == j) j = 0;

                }
            base.Write(result);
        }

    }
}

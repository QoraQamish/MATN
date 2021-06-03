using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATN
{
    public class MATNC
    {
        public string matn { get; set; }
        public void Save(string _matn)
        {
            this.matn = _matn;
        }
        public string Read()
        {
            return this.matn;
        }
        public virtual void Write(string v=null)
        {
            if (v == null) v = matn;
            Console.WriteLine(v);
        }
    }
}

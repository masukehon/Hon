using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<string> kha = new Element<string>("kha");
            Element<string> khang = new Element<string>("khang");
            List<string> list = new List<string>();
            list.ThemDau(kha);
            list.ThemDau(khang);
            list.In();
        }
    }
}

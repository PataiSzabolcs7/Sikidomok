using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Síkidomok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidomok = new List<Sikidom>();
            sikidomok.Add(new Kor());
            sikidomok.Add(new Teglalap());
            sikidomok.Add(new Negyzet());
        }
    }
}

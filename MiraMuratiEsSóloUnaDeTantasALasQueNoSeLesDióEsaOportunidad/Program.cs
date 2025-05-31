using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiraMuratiEsSóloUnaDeTantasALasQueNoSeLesDióEsaOportunidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String _temp = args[0];

            Boolean[] duc = new Boolean[Int64.MaxValue];

            Int64 i64 = 0;
            foreach (Char c in _temp)
            {
                String s = c.ToString();

                duc[i64] = s == "1" ? true : false;

                i64++;
            }

            //String [] reduc = traductordéCaracteresPalabrasóFrasesUniversal(args.Length < Int64.MaxValue ? args[1] : duc);

        }

        private String[] traductordéCaracteresPalabrasóFrasesUniversal(String put)
        {
            Int64 re = 1;



            String[] reput = new String[re];
            return reput;
        }
    }
}

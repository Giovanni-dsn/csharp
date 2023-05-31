using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorPix
{
    public class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<string> GetChavesPix(int quant)
        {
            if (quant <= 0 )
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < quant; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }
                return chaves;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string alvo = "2007-12-31";
            string pattern = @"(\d{4})(-)(\d{2})(-)(\d{2})";

            Regex regex = new Regex(pattern);
            MatchCollection Matches = regex.Matches(alvo);

            foreach(Match match in Matches)
            {
                //string dia = match.Groups[0].Value;
                string ano = match.Groups[1].Value;
                string mes = match.Groups[3].Value;
                string dia = match.Groups[5].Value;

                string separador1 = match.Groups[2].Value;
                string separador2 = match.Groups[4].Value;

                Console.WriteLine(String.Format("{0}{1}{2}{3}{4}", dia,separador1, mes,separador2, ano).Replace("-", "/"));


            }
        }
    }
}

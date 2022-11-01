using ABP_Dal.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP_Bll.Repositories
{
    public class Print
    {
        Parser parser = new Parser();

        public void PrintAtConsole()
        {
            parser.Start();

            for (var i = 0; i < parser.DivCode_n.Count; i++)
            {
                if (parser.DivNames.ElementAt(i) != null)
                {
                    Console.Write($"{i + 1}   -    ");
                    Console.WriteLine($"{parser.DivNames.ElementAt(i)}");
                }
                for (var j = 0; j < parser.DivCode_n.ElementAt(i).Count; j++)
                {
                    Console.Write($"{parser.DivCode_n.ElementAt(i).ElementAt(j)}   -    ");
                    Console.WriteLine($"{parser.DivComplectation_n.ElementAt(i).ElementAtOrDefault(j)}");
                    Console.WriteLine($"{parser.DivDateFrom_n.ElementAt(i).ElementAtOrDefault(j)}  -   {parser.DivDateTo_n.ElementAt(i).ElementAtOrDefault(j)}");
                    //Console.WriteLine($"{DivDate_n.ElementAt(i).ElementAtOrDefault(j)}");
                    //Console.WriteLine($"{divUrlToComplectation.ElementAt(i).ElementAt(j)}");
                }
                Console.WriteLine("____________________________");
            }
        }
    }
}

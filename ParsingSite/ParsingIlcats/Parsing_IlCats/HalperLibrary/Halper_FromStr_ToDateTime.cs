using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IlCats_Parsing.HalperLibrary
{
    public static class Halper_FromStr_ToDateTime
    {
        public static List<DateTime> ListFromStrToDateTime(List<string> listString, int i)
        {
            List<DateTime> listFromStrToDateTime = new List<DateTime>();

            char[] chars = Halper.FromListToCharArray(listString, i);

            List<int> ints = new List<int>();
            List<char> charsNotValid = new List<char>();

            for(var j = 0; j < chars.Length; j++)
            {
                int tP;

                //if(int.TryParse(chars[j].ToString(), out tP))
                //{
                //    int a = Convert.ToInt32(chars[j].ToString());
                //    ints.Add(a);
                //}

                try
                {
                    int a = Convert.ToInt32(chars[j].ToString());
                    ints.Add(a);
                }
                catch
                {
                    charsNotValid.Add(chars[j]);
                }
            }

            int x = 0;
            for (var j = 0; j < ints.Count / 6; j++)
            {
                string monthStr = $"{ints[j + x ]}{ints[(j + 1 ) + x]}";
                int monthInt = Convert.ToInt32(monthStr);

                string yearStr = $"{ints[(j + 2) + x]}{ints[(j + 3) + x]}{ints[(j + 4) + x]}{ints[(j + 5) + x]}";
                int yearInt = Convert.ToInt32(yearStr);

                var date = new DateTime(yearInt, monthInt, 1);

                listFromStrToDateTime.Add(date);

                x += 5;
            }

            return listFromStrToDateTime;
        }


        public static List<List<DateTime>> ListOnePartDateTime(int part, int countAllPare, List<List<string>> DivDate_n)
        {
            List<DateTime> ListDates = new List<DateTime>();

            List<List<DateTime>> DivDateFrom_n = new List<List<DateTime>>();
            List<List<DateTime>> DivDateTo_n = new List<List<DateTime>>();

            for (var i = 0; i < countAllPare; i++)
            {
                List<DateTime> DivDateFrom = new List<DateTime>();
                List<DateTime> DivDateTo = new List<DateTime>();

                for (var x = 0; x < DivDate_n.ElementAt(i).Count; x++)
                {
                    ListDates = ListFromStrToDateTime(DivDate_n.ElementAt(i), x);

                    if (ListDates.Count %2 != 0)
                    {
                        DateTime a = DateTime.Now;
                        ListDates.Add(a);
                    }
                    for(var j = 0; j < ListDates.Count; j++)
                    {
                        if( j %2 == 0)
                        {
                            DivDateTo.Add(ListDates[j]);
                        }
                        else
                        {
                            DivDateFrom.Add(ListDates[j]);
                        }
                    }
                }
                if(part == 1)
                DivDateFrom_n.Add(DivDateFrom);

                if (part == 2)
                    DivDateTo_n.Add(DivDateTo);
            }

            if (part == 1)
                return DivDateFrom_n;

            else 
                return DivDateTo_n;

        }
    }
}

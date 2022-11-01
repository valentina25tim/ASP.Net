using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ABP_Entity.HalperLibrary
{
    public static class Halper
    {
        public static char[] FromListToCharArray(List<string> list, int index)
        {
            int countChar = list.ElementAt(index).ToCharArray().Length;

            char[] charArray = new char[countChar];

            charArray = list.ElementAt(index).ToCharArray();
            return charArray;
        }


        public static string[] FromListToArray(List<string> list)
        {
            string[] array = new string[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }


        public static List<string> FromCharArrayToStringList(char[] array)
        {
            List<string> list = new List<string>();
            for (var i = 0; i < array.Length; i++)
            {
                list.Add(array[i].ToString());
            }
            return list;
        }

        public static string[] SplitTextToWords(string[] fullText, int index)
        {
            string[] fullWords = fullText[index].Split(new char[] { ' ', ',', '.', ':', ';', '!', '?', '/', '\n', '\t', '"', '&', '*', '%', '@', '-' }, StringSplitOptions.RemoveEmptyEntries);
            return fullWords;
        }


        public static List<List<string>> SelectCurrentCharToList(List<List<string>> fullWordsAllCharList, List<string> divConsistCharList) // 0
        {
            List<List<string>> listCurrentChars = new List<List<string>>();

            int whileDo = 0;

            int j = 0;

            do
            {
                int y = 0;

                List<string> CurrentChars = new List<string>();
                int countCharWord = fullWordsAllCharList.ElementAt(j).Count;
                
                for (var i = 0; i < divConsistCharList.Count; i++) //71   i max = 71
                {
                    string a = divConsistCharList.ElementAt(i);

                    string b = fullWordsAllCharList.ElementAt(j).ElementAt(y);


                    if (divConsistCharList.ElementAt(i) == fullWordsAllCharList.ElementAt(j).ElementAt(y))
                    {
                        CurrentChars.Add(divConsistCharList.ElementAt(i));

                        y += 1;

                    }
                    if (y + 1 <= countCharWord && i + 1 != divConsistCharList.Count)
                    {

                        string h = divConsistCharList.ElementAt(i + 1);


                        string h1 = fullWordsAllCharList.ElementAt(j).ElementAt(y);


                        if (CurrentChars.Count > 0 && CurrentChars.Count != countCharWord && divConsistCharList.ElementAt(i + 1) != fullWordsAllCharList.ElementAt(j).ElementAt(y))
                        {
                            if (CurrentChars.Count == fullWordsAllCharList.ElementAt(j).Count - 1)
                            {
                                i = divConsistCharList.Count;
                            }
                            y = 0;

                            CurrentChars.Clear();
                        }
                    }
                    if (CurrentChars.Count == countCharWord)
                    {
                        listCurrentChars.Add(CurrentChars);

                        i = divConsistCharList.Count;

                        y = 0;
                    }
                }
                

                if (j != fullWordsAllCharList.Count)
                {
                    j += 1; whileDo += 1;
                }

            } while (whileDo != fullWordsAllCharList.Count);

            return listCurrentChars;
        }
    

                // 6 7 1 4 4 0
                // 4 - r u n n e r " " t r u c k 6 7 1 4 4 0 0 8































                //List<List<string>> listCurrentChars = new List<List<string>>();
                //int z = 0;
                //int x = 0;
                //do
                //{
                //    List<string> currentWord = new List<string>(0);

                //    int c = 0;
                //    int count = fullWordsAllCharList.ElementAt(z).Count();

                //    while (currentWord.Count != count && x != divConsistCharList.Count)
                //    {
                //        if (fullWordsAllCharList.ElementAt(z).ElementAt(c) == divConsistCharList.ElementAt(x))
                //        {
                //            currentWord.Add(fullWordsAllCharList.ElementAt(z).ElementAt(c));
                //            c += 1;

                //            if (currentWord.Count == count)
                //            {
                //                listCurrentChars.Add(currentWord);
                //            }
                //        }
                //        else
                //            x += 1;
                //    }
                //    z += 1;

                //} while (x != divConsistCharList.Count);

                //return listCurrentChars;


        public static List<string> ListByStrBuilder(List<List<string>> listCurrentChars)
        {
            List<string> listByStrBuilder = new List<string>();
            
            for(var i = 0; i < listCurrentChars.Count; i++)
            {
                var str = new StringBuilder();

                for (var j = 0; j < listCurrentChars.ElementAt(i).Count; j++)
                {
                    str.Append(listCurrentChars.ElementAt(i).ElementAt(j));

                    if(str.Length == listCurrentChars.ElementAt(i).Count)
                    {
                        listByStrBuilder.Add(str.ToString());
                    }
                }
            }

            return listByStrBuilder;
        }
    }
}

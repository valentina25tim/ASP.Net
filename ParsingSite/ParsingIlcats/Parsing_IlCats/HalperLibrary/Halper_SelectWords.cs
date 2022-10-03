using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace IlCats_Parsing.HalperLibrary
{
    public static class Halper_SelectWords
    {
        public static List<string>SelectCurrentWords(List<string> DivConsistString, List<string> divAllContentItem, int index)
        { 
            List<string>listCurrentWords = new List<string>(); // current words for model

            List<List<string>> listCurrentChars = new List<List<string>>();

            List<string> divConsistCharList = new List<string>();
            


            char[] divConsistCharArray = new char[DivConsistString.ElementAt(index).Length]; // разбила одну Нужную полную Див строку на чары
            divConsistCharArray = Halper.FromListToCharArray(DivConsistString, index);// char array from <div> with full content about ModelCar
            divConsistCharList = Halper.FromCharArrayToStringList(divConsistCharArray);//List string(1char) from <div> with full content about ModelCar


            List<List<string>> fullWordsAllCharList = new List<List<string>>(divAllContentItem.Count);
            

            for (var j = 0; j < divAllContentItem.Count; j++)
            {
                char[] fullWordsCharArray = new char[divAllContentItem.ElementAt(j).Length];
                List<string> fullWordsCharList = new List<string>();

                fullWordsCharArray = Halper.FromListToCharArray(divAllContentItem, j); // char array for one word for each model
                fullWordsCharList = Halper.FromCharArrayToStringList(fullWordsCharArray); //List string(1char) for each model
                fullWordsAllCharList.Add(fullWordsCharList); //List <List string(1char)> for each model
            }

            listCurrentChars = Halper.SelectCurrentCharToList(fullWordsAllCharList, divConsistCharList);
            listCurrentWords = Halper.ListByStrBuilder(listCurrentChars);

            return listCurrentWords;
        }
    }
}

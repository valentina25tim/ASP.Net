using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ABP_Entity.HalperLibrary
{
    public static class Halper_Parsing
    {
        public static List<string> ListParsedContent(List<HtmlAgilityPack.HtmlNode> divConsistHtml, List<string> DivConsistString, int i, string selector)
        {
            List<string> listParsedContent = new List<string>();

            List<string> divAllContentItem = new List<string>();

            var items = divConsistHtml.ElementAt(i).SelectNodes(selector);

            if (items != null)
            {
                foreach (var item in items)
                {
                    divAllContentItem.Add(item.InnerText);
                }
            }

             listParsedContent = Halper_SelectWords.SelectCurrentWords(DivConsistString, divAllContentItem, i);
            
            return listParsedContent;
        }
    }
}
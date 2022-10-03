using IlCats_Parsing.HalperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Parsing_IlCats
{
    public class Parsing_Catalog
    {
        public List<string> DivNames = new List<string>();
        public List<List<string>> DivCode_n = new List<List<string>>();
        public List<List<DateTime>> DivDateFrom_n = new List<List<DateTime>>();
        public List<List<DateTime>> DivDateTo_n = new List<List<DateTime>>();
        public List<List<string>> DivComplectation_n = new List<List<string>>();

        private List<string> divConsist = new List<string>();
        private List<HtmlAgilityPack.HtmlNode> divConsistHtml = new List<HtmlAgilityPack.HtmlNode>();
        private List<List<string>> divDate_n = new List<List<string>>();

        public void Start()
        {
           CarModelParsing("https://www.ilcats.ru/toyota/?function=getModels&market=EU");
        }

        public void PrintAtConsole()
        {
            Start();

            for (var i = 0; i < DivCode_n.Count; i++)
            {
                if (DivNames.ElementAt(i) != null)
                {
                    Console.Write($"{i + 1}   -    ");
                    Console.WriteLine($"{DivNames.ElementAt(i)}");

                }
                for (var j = 0; j < DivCode_n.ElementAt(i).Count; j++)
                {
                    Console.Write($"{DivCode_n.ElementAt(i).ElementAt(j)}   -    ");
                    Console.WriteLine($"{DivComplectation_n.ElementAt(i).ElementAtOrDefault(j)}");
                    Console.WriteLine($"{DivDateFrom_n.ElementAt(i).ElementAtOrDefault(j)}  -   {DivDateTo_n.ElementAt(i).ElementAtOrDefault(j)}");
                    //Console.WriteLine($"{DivDate_n.ElementAt(i).ElementAtOrDefault(j)}");
                }
                Console.WriteLine("____________________________");
            }
        }
        private void CarModelParsing(string url)
        {
            try
            {
                using (HttpClientHandler hdl = new HttpClientHandler
                {
                    AllowAutoRedirect = false,
                    AutomaticDecompression = System.Net.DecompressionMethods.Deflate |
                    System.Net.DecompressionMethods.GZip |
                    System.Net.DecompressionMethods.None
                })

                using (var client = new HttpClient(hdl))
                {
                    using (HttpResponseMessage response = client.GetAsync(url).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var html = response.Content.ReadAsStringAsync().Result;
                            if (!string.IsNullOrEmpty(html))
                            {
                                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                doc.LoadHtml(html);

                                divConsistHtml = doc.DocumentNode.SelectNodes("html/body/div/div/div[@class='List']").ToList();// содержание Дива листа 

                                var names = doc.DocumentNode.SelectNodes(".//div[@class = 'List']//div[@class = 'Header']//div[@class = 'name']"); //чистое имя


                                for (var i = 0; divConsistHtml.Count > i; i++)
                                {
                                    if (divConsistHtml.ElementAt(i) != null)
                                    {
                                        divConsist.Add(divConsistHtml.ElementAt(i).InnerText); // содержание Дива листа  в виде текста одной модели 
                                        DivNames.Add(names.ElementAt(i).InnerText); // содержание Дива листа  в виде текста одной модели 
                                    }
                                }
                            }
                        }
                    }
                }
                for (var i = 0; i < divConsist.Count; i++)
                {
                    List<string> _divCode = new List<string>();
                    _divCode = Halper_Parsing.ListParsedContent(divConsistHtml, divConsist, i, "//div[@class ='id']/a");
                    DivCode_n.Add(_divCode);

                    List<string> _divComplectation = new List<string>();
                    _divComplectation = Halper_Parsing.ListParsedContent(divConsistHtml, divConsist, i, "//div[@class ='modelCode']");
                    DivComplectation_n.Add(_divComplectation);

                    List<string> _divDates = new List<string>();
                    _divDates = Halper_Parsing.ListParsedContent(divConsistHtml, divConsist, i, "//div[@class ='dateRange']");
                    divDate_n.Add(_divDates);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DivDateFrom_n = Halper_FromStr_ToDateTime.ListOnePartDateTime(2, DivCode_n.Count, divDate_n);
            DivDateTo_n = Halper_FromStr_ToDateTime.ListOnePartDateTime(1, DivCode_n.Count, divDate_n);
        }



















        //private IEnumerable<ModelCarType> modelCarTypes(List<List<string>> DivCode_n, List<List<DateTime>> DivDateFrom_n, List<List<DateTime>> DivDateTo_n, List<List<string>> DivComplectation_n, int index)
        //{
        //    List<ModelCarType> mct = new List<ModelCarType>();

        //    for (var i = 0; i < DivCode_n.ElementAt(index).Count; i++)
        //    {
        //        ModelCarType model = new ModelCarType
        //        {
        //            Code = DivCode_n.ElementAt(index).ElementAt(i),
        //            //DateFrom = DivDateFrom_n.ElementAt(index).ElementAt(i),
        //            //DateTo = DivDateTo_n.ElementAt(index).ElementAt(i),
        //            Complectation = DivComplectation_n.ElementAt(index).ElementAt(i),
        //        };
        //        mct.Add(model);
        //    }
        //    return mct;
        //}
        































        //public static Dictionary<string, Dictionary<string, List<string>>> Parsing(string url)
        //{
        //    Dictionary<string, Dictionary<string, List<string>>> catalog;

        //    Dictionary<string, List<string>> codeWithContent;

        //    List<List<string>> DivListConsist = new List<List<string>>();
        //    List<string> DivConsist;

        //    List<string> DivAllCode = new List<string>();
        //    List<string> DivAllDateRange = new List<string>();
        //    List<string> DivAllComplectation = new List<string>();

        //    List<string> DivCode = new List<string>();
        //    List<string> DivDateRange = new List<string>();
        //    List<string> DivComplectation = new List<string>();

        //    try
        //    {
        //        catalog = new Dictionary<string, Dictionary<string, List<string>>>();

        //        using (HttpClientHandler hdl = new HttpClientHandler
        //        {
        //            AllowAutoRedirect = false,
        //            AutomaticDecompression = System.Net.DecompressionMethods.Deflate |
        //             System.Net.DecompressionMethods.GZip |
        //             System.Net.DecompressionMethods.None
        //        })

        //        using (var client = new HttpClient(hdl))
        //        {
        //            using (HttpResponseMessage response = client.GetAsync(url).Result)
        //            {
        //                if (response.IsSuccessStatusCode)
        //                {
        //                    var html = response.Content.ReadAsStringAsync().Result;
        //                    if (!string.IsNullOrEmpty(html))
        //                    {
        //                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        //                        doc.LoadHtml(html);

        //                        var names = doc.DocumentNode.SelectNodes(".//div[@class = 'List']//div[@class = 'Header']//div[@class = 'name']"); //чистое имя

        //                        var divConsist = doc.DocumentNode.SelectNodes("html/body/div/div/div[@class='List']").ToList();// содержание Дива листа 

        //                        for (var i = 0; divConsist.Count > 0; i++)
        //                        {
        //                            DivConsist = new List<string>();

        //                            if (divConsist.ElementAt(i) != null)
        //                            {
        //                                DivConsist.Add(divConsist.ElementAt(i).InnerText); // содержание Дива листа  в виде текста одной модели 
        //                            }
        //                            DivListConsist.Add(DivConsist); // содержание Дива листа  в виде текста всех моделей

        //                            var model_codes = divConsist.ElementAt(i).SelectNodes($"//div[@class ='id']/a");
        //                            var dateRanges = divConsist.ElementAt(i).SelectNodes($"//div[@class ='dateRange']");
        //                            var complectations = divConsist.ElementAt(i).SelectNodes($"//div[@class ='modelCode']");

        //                            if (model_codes != null && model_codes.Count > 0 && dateRanges != null && dateRanges.Count > 0 && complectations != null && complectations.Count > 0)
        //                            {
        //                                foreach (var model_code in model_codes)
        //                                {
        //                                    DivAllCode.Add(model_code.InnerText);
        //                                }
        //                                foreach (var dateRange in dateRanges)
        //                                {
        //                                    DivAllDateRange.Add(dateRange.InnerText);
        //                                }
        //                                foreach (var complectation in complectations)
        //                                {
        //                                    DivAllComplectation.Add(complectation.InnerText);
        //                                }

        //                                DivCode = Halper_SelectWords.SelectCurrentWords(DivListConsist.ElementAt(i), DivAllCode, i);
        //                                DivDateRange = Halper_SelectWords.SelectCurrentWords(DivListConsist.ElementAt(i), DivAllDateRange, i);
        //                                DivComplectation = Halper_SelectWords.SelectCurrentWords(DivListConsist.ElementAt(i), DivAllComplectation, i);
        //                            }

        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return null;
        //}
    }
}
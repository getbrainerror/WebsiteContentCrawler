using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebsiteContentCrawler
{
    class Crawler
    {


        public static string[] Crawl(Regex[] regexArr, string[] urlArr)
        {
            var results = new List<string>();

            foreach (var regex in regexArr)
            {
                var tmpUrls = new List<string>();
                foreach (var url in urlArr)
                {
                    string source = GetWebsiteSource(url);
                    if (source != "")
                    {
                        tmpUrls.AddRange(Search(regex, source));
                    }
                }
                if (regex.Equals(regexArr.Last()))
                {
                    results = tmpUrls;
                } else
                {
                    urlArr = tmpUrls.ToArray();
                }
            }

            return results.ToArray();
        }

        private static string GetWebsiteSource(string url)
        {
            string source = "";
            try
            {
                using (WebClient client = new WebClient())
                {
                    source = client.DownloadString(url);
                }
            }
            catch (Exception)
            {
               
            }

            return source;
        }

        private static string[] Search(Regex regex, string source)
        {
            var results = new List<string>();
            foreach (Match match in regex.Matches(source))
            {
                results.Add(match.Value);
            }
            return results.ToArray();
        }
    }
}

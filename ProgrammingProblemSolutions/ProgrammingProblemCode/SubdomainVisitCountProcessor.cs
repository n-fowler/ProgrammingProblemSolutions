using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class SubdomainVisitCountProcessor
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string cpdomain in cpdomains)
            {
                int count = Convert.ToInt32(cpdomain.Split(' ')[0]);
                string[] subdomains = cpdomain.Split(' ')[1].Split('.');

                for (int i = 0; i < subdomains.Length; i++)
                {
                    string subdomain = string.Join('.', subdomains, i, subdomains.Length - i);
                    if (dict.ContainsKey(subdomain))
                    {
                        dict[subdomain] += count;
                    }
                    else
                    {
                        dict.Add(subdomain, count);
                    }
                }
            }

            return dict.Select(keyValuePair => $"{keyValuePair.Value} {keyValuePair.Key}").ToList();
        }
    }
}

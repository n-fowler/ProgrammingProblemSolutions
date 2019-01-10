using System;
using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    /// <summary>
    /// In a business setting I would use a Bijective Function and encode/decode from that set, storing it with a unique id, but that's overkill here
    /// </summary>
    public class TinyUrlProcessor
    {
        private Dictionary<string, string> TinyUrls { get; set; }

        // Encodes a URL to a shortened URL
        public string Encode(string longUrl)
        {
            char[] charArray = new char[6];
            for (int i = 0; i < 6; i++)
            {
                charArray[i] = GetRandomLetter();
            }

            if (TinyUrls == null)
            {
                TinyUrls = new Dictionary<string, string>();
            }

            string tinyUrl = "http://tinyurl.com/" + new string(charArray);

            TinyUrls.Add(tinyUrl, longUrl);
            return tinyUrl;
        }

        // Decodes a shortened URL to its original URL.
        public string Decode(string shortUrl)
        {
            return TinyUrls.GetValueOrDefault(shortUrl);
        }

        private char GetRandomLetter()
        {
            int randomNumber = new Random().Next(1, 26);
            char[] letters =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                'w', 'x', 'y', 'z'
            };

            return letters[randomNumber];
        }
    }
}

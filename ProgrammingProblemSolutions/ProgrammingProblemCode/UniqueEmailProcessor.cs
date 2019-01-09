using System.Collections.Generic;

namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class UniqueEmailProcessor
    {
        public int GetUniqueEmailCount(string[] emails)
        {
            List<string> uniqueEmailList = new List<string>();

            foreach (string email in emails)
            {
                string[] emailParts = email.Split('@');
                string localName = emailParts[0];
                string domainName = emailParts[1];


                localName = localName.Replace(".", "");
                localName = localName.Split('+')[0];

                string parsedEmail = localName + "@" + domainName;

                if (!uniqueEmailList.Contains(parsedEmail))
                {
                    uniqueEmailList.Add(parsedEmail);
                }
            }

            return uniqueEmailList.Count;
        }
    }
}

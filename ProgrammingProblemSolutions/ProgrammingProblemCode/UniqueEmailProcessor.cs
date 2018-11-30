namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class UniqueEmailProcessor
    {
        public int GetUniqueEmailCount(string[] emails)
        {
            string[] processedEmails = new string[emails.Length];
            int duplicateEmails = 0;
            foreach (string email in emails)
            {
                string[] emailNamePair = email.Split('@');
                emailNamePair[0] = emailNamePair[0].Replace(".", "");
                emailNamePair[0] = emailNamePair[0].Split('+')[0];
                string emailNamePairString = string.Join(emailNamePair[0], emailNamePair[1]);


                if (processedEmails.Length == 0)
                {
                    processedEmails[0] = emailNamePairString;
                }
                else
                {
                    bool foundEmail = false;
                    foreach (string processedEmail in processedEmails)
                    {
                        if (processedEmail == emailNamePairString)
                        {
                            foundEmail = true;
                            duplicateEmails++;
                        }
                    }

                    if (!foundEmail)
                    {
                        processedEmails[processedEmails.Length - 1] = string.Join(emailNamePair[0], emailNamePair[1]);
                    }
                }
            }

            return processedEmails.Length - duplicateEmails;
        }
    }
}

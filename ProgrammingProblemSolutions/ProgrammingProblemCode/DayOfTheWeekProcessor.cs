namespace ProgrammingProblemSolutions.ProgrammingProblemCode
{
    public class DayOfTheWeekProcessor
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            int[] t = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            year -= (month < 3) ? 1 : 0;

            return GetDayOfWeek((year + year / 4 - year / 100 + year / 400 + t[month - 1] + day) % 7);
        }

        private string GetDayOfWeek(int dayOfWeekInt)
        {
            switch (dayOfWeekInt)
            {
                case 0:
                    return "Sunday";
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
            }

            return string.Empty;
        }
    }
}

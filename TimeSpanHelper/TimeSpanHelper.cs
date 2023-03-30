namespace TimeSpanHelper
{
    public class TimeSpanHelper
    {
        static void Main(string[] args)
        {
            TimeSpanHelper timeSpanHelper = new TimeSpanHelper();
            int toSecondsOne = timeSpanHelper.ToSeconds(4, 30);
            int toSecondsTwo = timeSpanHelper.ToSeconds(4, 30, 100);

            Console.WriteLine($"The Result of the first version is: {toSecondsOne} seconds");
            Console.WriteLine($"The Result of the second version is: {toSecondsTwo} seconds");
        }
        public int ToSeconds(int hours, int minutes)
        {
            int secondsOne = (hours * 3600) + (minutes * 60);
            return secondsOne;
        }
        public int ToSeconds(int hours, int minutes, int seconds)
        {
            int secondsTwo = (hours * 3600) + (minutes * 60) + seconds;
            return secondsTwo;
        }
    }
}
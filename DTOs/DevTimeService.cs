using DI.Interfaces;

namespace DI.DTOs
{
    public class DevTimeTimeService : ITimeService
    {
        public string GetTime()
        {
            string longData = DateTime.Now.ToLongTimeString();
            Console.WriteLine(longData);
            return longData;
        }
    }
}

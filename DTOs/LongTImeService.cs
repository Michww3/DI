using DI.Interfaces;

namespace DI.DTOs
{
    public class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}

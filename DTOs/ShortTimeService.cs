using DI.Interfaces;

namespace DI.DTOs
{
    public class ShortTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}

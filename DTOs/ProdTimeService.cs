using DI.Interfaces;

namespace DI.DTOs
{
    public class ProdTimeService : ITimeService
    {
        public string GetTime()
        {
            string time = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToLongDateString();

            string template = File.ReadAllText("Templates/prodTemplate.html");

            template = template.Replace("{{date}}", date)
                               .Replace("{{time}}", time);

            return template;
        }
    }
}
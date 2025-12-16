using DI.Interfaces;

namespace DI.DTOs
{
    public class ProdTimeService : ITimeService
    {
        public string GetTime()
        {
            string time = DateTime.Now.ToShortTimeString();
            string date = DateTime.Now.ToLongTimeString();
            return $@"
                <!DOCTYPE html>
                <html lang=""ru"">
                <head>
                <meta charset=""UTF-8"">
                <title>Текущее время</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background: linear-gradient(135deg, #f0f0f0, #dcdcdc);
                        color: #333;
                        text-align: center;
                        padding-top: 50px;
                    }}
                    h1 {{
                        color: #2c3e50;
                        font-size: 2.5em;
                    }}
                    p {{
                        font-size: 1.5em;
                        color: #16a085;
                    }}
                </style>
                </head>
                <body>
                <h1>Текущая дата и время</h1>
                <p> {date}</p>
                <p> {time}</p>
                </body>
                </html>";
        }
    }
}

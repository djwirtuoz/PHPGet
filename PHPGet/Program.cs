using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace PHPGet
{
    class Program
    {

        static void Main(string[] args)
        {
            string content = "";
            HttpRequest req = new HttpRequest();
            HttpResponse response;
            req.UserAgent = Http.ChromeUserAgent();

            String login = "";
            String pass = "";

            while (login != "Exit")
            {
                Console.Write("");
                login = Console.ReadLine();
                Console.Write("");
                pass = Console.ReadLine();

                using (var request = new HttpRequest())
                {
                    request.UserAgent = Http.ChromeUserAgent();

                    try
                    {
                        // Отправляем запрос.
                         response = request.Get("http://djwirtuoz.ru/message.php?login=" + login + "&pass=" + pass);
                        // Принимаем тело сообщения в виде строки.
                        content = response.ToString();
                        Console.WriteLine(content);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                }

                if (content == "succes")
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}

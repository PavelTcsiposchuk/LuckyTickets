using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.ShowInstruction();
            string path = UI.GetPath();
            List<string> arguments = ReadFile(path);
            if(!Validator.IsArgumentsValid(arguments,out string message))
            {
                UI.ShowError(message);
            }
            else
            {
                TicketAnalyzator analyzator = GetTicketAnalyzator(arguments);
                UI.ShowCountLuckyTickets(analyzator.CountLuckyTickets());
            }
           
            Console.Read();
        }
        static TicketAnalyzator GetTicketAnalyzator(List<string> arguments)
        {
            TicketAnalyzator analyzator = null; 

            if(arguments[0].ToUpper() == "MOSKOW")
            {
                analyzator = new MoscowTicketAnalyzator(Convert.ToInt32(arguments[1]), Convert.ToInt32(arguments[2]));
            }
            else
            {
                analyzator = new PiterTicketAnalyzator(Convert.ToInt32(arguments[1]), Convert.ToInt32(arguments[2]));
            }
            UI.ShowInformationAboutAnalyzator(arguments[0], arguments[1], arguments[2]);

            return analyzator;
        }
        static List<string> ReadFile (string path)
        {
            List<string> arguments = new List<string>(3);

            using (StreamReader strReader = new StreamReader(path))
            {
                arguments.Add(strReader.ReadLine());
                arguments.Add(strReader.ReadLine());
                arguments.Add(strReader.ReadLine());
            }

            return arguments;
        }

    }
}

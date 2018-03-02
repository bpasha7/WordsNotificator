using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordsNotificator
{
    public class MySettings
    {
        //public TimeSpan Interva { get; set; }
        //public TimeSpan From { get; set; }
        //public TimeSpan Till { get; set; }

        public Dictionary<string, bool> Days;
        public Dictionary<string, TimeSpan> Times;

        public MySettings()
        {
            string line;
            Days = new Dictionary<string, bool>();
            Times = new Dictionary<string, TimeSpan>();
            System.IO.StreamReader file = new System.IO.StreamReader("settings.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line[0] == '#')
                    continue;
                var parameter = line.Split(new char[] { '=', ':' }, StringSplitOptions.RemoveEmptyEntries);
                switch (parameter[0])
                {
                    case "INTERVAL":
                        Times.Add(parameter[0], new TimeSpan(Convert.ToInt32(parameter[1]), Convert.ToInt32(parameter[2]), 0));
                        break;
                    case "FROM":
                        Times.Add(parameter[0], new TimeSpan(Convert.ToInt32(parameter[1]), Convert.ToInt32(parameter[2]), 0));
                        break;
                    case "TILL":
                        Times.Add(parameter[0], new TimeSpan(Convert.ToInt32(parameter[1]), Convert.ToInt32(parameter[2]), 0));
                        break;
                    default:
                        Days.Add(parameter[0], Convert.ToBoolean(parameter[1]));
                        break;
                }
            }
            file.Close();
        }
        //public bool MONDAY { get; set; }
        //public bool TUESDAY { get; set; }
        //public bool WEDNESDAY { get; set; }
        //public bool THURSDAY { get; set; }
        //public bool FRIDAY { get; set; }
        //public bool SATURDSY { get; set; }
        //public bool SUNDAY { get; set; }



    }
}

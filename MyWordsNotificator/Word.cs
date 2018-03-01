using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWordsNotificator
{
    public class MyWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string Description { set; get; }
        public bool Skip { get; set; }
        public int Shown { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1_chat
{
    public class Chat
    {
        public string Text { get; set; }
        public DateTime Datetime {get;set;}
       
            public Chat(string text, DateTime dt)
        {
            Text = text;
            Datetime = dt;
        }
       
    }
}

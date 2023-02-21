using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic2_4__in_WPF
{
    internal class Note
    {
            public string name;
            public string bank;
            public string time;
            public Note(string Name, string Bank, string Time)
            {
                this.name = Name;
                this.bank = Bank;
                this.time = Time;
            }
    }
}

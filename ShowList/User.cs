using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList
{
    public abstract class User
    {
       public string FirstName;
       public List<Show> Library { get; set; } = new List<Show>();
        public object Shows { get; internal set; }

        public User(string name) {
            this.FirstName = name;
        }
    }
}

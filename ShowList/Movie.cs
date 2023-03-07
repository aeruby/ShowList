using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ShowList;

namespace ShowList
{
    public class Movie : Show
    {
        public int TimeDuration { get; private set; }


        public Movie(string title, Genre genre, int yearReleased, int companyId, int timeDuration) : base(title, genre, yearReleased, companyId)
        {
            this.TimeDuration = timeDuration;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTimeDuration: " + TimeDuration.ToString() + "minutes";
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList
{
    public class Drama: Show
    {
        public int Episode { get; private set; }
        public Drama(string title, Genre genre, int yearReleased, int companyId, int episode) : base(title, genre, yearReleased, companyId)
        {
            this.Episode = episode;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTimeDuration: " + TimeDuration.ToString() + "minutes";
        }
    }

}

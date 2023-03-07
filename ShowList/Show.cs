using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList
{
    public class Show
    {
        public string Title { get; private set; }
        public Genre Genre { get; private set; }
        public int YearReleased { get; private set; }
        public int CompanyId { get; private set; }

        public Show(string title, Genre genre, int yearReleased, int companyId)
        {
            this.Title = title;
            this.Genre = Genre;
            this.YearReleased = yearReleased;
            this.CompanyId = companyId;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTitle: " + Title.ToString() + "\nGenre: " + Genre.ToString() + "\nYear Released: " + YearReleased.ToString() + "\nCompany ID:" + CompanyId.ToString(); 
        }
    }
}

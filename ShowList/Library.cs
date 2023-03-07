using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList
{
    public class Library:User
    {
        public static List<Show> Shows { get; set; } = new List<Show>();

        public void AddShow(User user, Show show)
        {
            user.Shows.Add(show);
        }

        public void RemoveShow(User user, Show show)
        {
            user.Shows.Remove(show);
        }
    }
}

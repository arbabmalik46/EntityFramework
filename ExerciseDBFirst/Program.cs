using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context =new PracticeDBEntities();
            Genre genre = new Genre()
            {
                GenreID = 1,
                Name = "Funny",
            };
            context.SaveChanges();
        }
    }
}

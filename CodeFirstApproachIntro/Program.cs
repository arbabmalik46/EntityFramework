using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachIntro
{
    public class BlogDBContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

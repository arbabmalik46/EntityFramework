using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new BusinessEntities();
            var prsn = new PRSN()
            {
                FirstName = "Sana",
                LastName = "Sheikh",
                Address = "Ali Town",
                City = "Lahore"//,
                //PersonID = 501
            };
            context.PRSNs.Add(prsn);
            context.SaveChanges();
        }
    }
}

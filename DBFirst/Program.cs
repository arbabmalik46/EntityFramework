using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Executing Method
            //var plutoContext = new PlutoDbContext();
            //var courses = plutoContext.GetCourses(); 
            //SslStream sslStream = null;
            //sslStream.ReadTimeout = 0;
            //foreach (var item in courses)
            //{
            //    Console.WriteLine(item.Title + " "+ item.CourseID + " "+item.LevelString+" "+item.Price);
            //}
            //Console.Read();
            #endregion

            #region Execute the context
            var course = new Courses();
            course.Level = CourseLevel.Begineer;
            var CourseContext = new PlutoDbContext();
            CourseContext.Courses.Add(course);
            try
            {
                int ad = CourseContext.SaveChanges();

                if (ad > 0)
                {
                    Console.WriteLine("Work Done");
                    Console.Read();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                Console.ReadLine();
            }
            
            #endregion
        }
    }
}

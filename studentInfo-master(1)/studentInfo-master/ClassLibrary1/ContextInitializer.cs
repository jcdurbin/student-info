using Netchemia.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

// only needed when using database
namespace Netchemia.Data
{
    //class ContextInitializer : DropCreateDatabaseIfModelChanges<Context>
    class ContextInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            //Students
            context.Students.Add(new Student
            {
                FirstName = "Michael",
                LastName = "Jordan",
                PhoneNumber = "913-555-2323",
                Address = "Chicago, IL",
                StudentType = "doctorate",
                AreActive = true,
            });

            context.Students.Add(new Student
            {
                FirstName = "Magic",
                LastName = "Johnson",
                PhoneNumber = "913-555-3232",
                Address = "Los Angeles, CA",
                StudentType = "graduate",
                AreActive = true,
            });

            context.Students.Add(new Student
            {
                FirstName = "Bill",
                LastName = "Russell",
                PhoneNumber = "816-555-0606",
                Address = "Boston, MA",
                StudentType = "undergraduate",
                AreActive = true,
            });

            context.Students.Add(new Student
            {
                FirstName = "Larry",
                LastName = "Bird",
                PhoneNumber = "816-555-3333",
                Address = "Boston, MA",
                StudentType = "undergraduate",
                AreActive = true,
            });

            base.Seed(context);
        }
    }
}

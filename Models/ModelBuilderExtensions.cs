using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>().HasData(

                new Library
                {
                    Id = 4,
                    Department = Dept.Account,
                    NameofAuthor = "James John",
                    Title = "Principles of Economics"
                },

                new Library
                {
                    Id = 5,
                    Department = Dept.CivilEngineering,
                    NameofAuthor = "Nkem Ijeoma ",
                    Title = "Drawings for Engineers"
                },

                new Library
                {
                    Id = 6,
                    Department = Dept.ElectricalEngineering,
                    NameofAuthor = "Egwale Francis",
                    Title = "Project Defense"
                }




                );
        }
    }
}

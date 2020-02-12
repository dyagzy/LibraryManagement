using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class SQLLibraryRepository : ILibraryRepository
    {
        private readonly AppDbContext context;

        public SQLLibraryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Library Add(Library library)
        {
            context.Libraries.Add(library);
            context.SaveChanges();
            return library;
        }

        public Library Delete(int id)
        {
            Library library =context.Libraries.Find(id);
            if(library != null)
            {
                context.Libraries.Remove(library);
            }
            return library;
        } 

        public IEnumerable<Library> GetAllBooks()
        {
            return context.Libraries;
        }

        public Library GetBook(int id)
        {
            return context.Libraries.Find(id);
        }

        public Library Update(Library librarychanges)
        {
            var library = context.Libraries.Attach(librarychanges);
            library.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return librarychanges;
        }
    }
}

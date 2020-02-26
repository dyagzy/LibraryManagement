using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class SQLLibraryRepository : ILibraryRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLLibraryRepository> logger;

        public SQLLibraryRepository(AppDbContext context,
            ILogger<SQLLibraryRepository> logger)
        {
            this.context = context;
            this.logger = logger;
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
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogCritical("Critical Log");
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

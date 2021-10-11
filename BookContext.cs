using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp36
{
    class BookContext :DbContext
    {

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public BookContext(DbContextOptions options) : base(options)
        {
        }

        public BookContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=mydb;Trusted_Connection=True;MultipleActiveResultSets=True");

    }
}

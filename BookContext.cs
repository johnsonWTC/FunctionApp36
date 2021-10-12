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
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=ASSET-10422\\SQLEXPRESS;Initial Catalog=BackEndDBTest;Integrated Security=True");

    }
}

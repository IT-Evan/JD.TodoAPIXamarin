using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JD.TodoAPIXamarin.Models
{
    public class JDTodoAPIXamarinContext : DbContext
    {
        public JDTodoAPIXamarinContext (DbContextOptions<JDTodoAPIXamarinContext> options)
            : base(options)
        {
        }

        public DbSet<JD.TodoAPIXamarin.Models.ToDoItem> ToDoItem { get; set; }
    }
}

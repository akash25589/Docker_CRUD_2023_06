using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CRUD_2023_06.Models
{
    public class MyFruits
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the name of fruit")]
        public string fruitname { get; set; } 

        public int fruitquantity { get; set; }
    }

    public class DB : DbContext
    {
        public DB()
        {
                
        }

        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        public DbSet<MyFruits> myCRUD { get; set; }
        public DbSet<Fruits_Data> Fruits_details { get; set; }

    }
}

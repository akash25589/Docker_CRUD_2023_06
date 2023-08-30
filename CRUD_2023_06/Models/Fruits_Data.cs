using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CRUD_2023_06.Models
{
    public class Fruits_Data
    {
        [Key]
        public int FruitId { get; set; }

        public string FruitName { get; set; }

    }

    
}

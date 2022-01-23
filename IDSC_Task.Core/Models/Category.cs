using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.Core.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } 
        [Required, MaxLength(150)]
        public string Name { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 20)]

        public string Description { get; set; }

        [ForeignKey("News")]
       
        public int NewsId { get; set; }

        public News News { get; set; }
    }
}

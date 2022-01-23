using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSC_Task.Core.Models
{
    public class Source
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]

        public string Name { get; set; }
        [StringLength(int.MaxValue, MinimumLength = 20)]

        public string Description { get; set; }

    }
}

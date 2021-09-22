using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public string Country { get; set; }

    }
}

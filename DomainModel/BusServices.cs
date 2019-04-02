using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModel
{
    public class BusService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
    }
}

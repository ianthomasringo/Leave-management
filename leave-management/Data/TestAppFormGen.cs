using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class TestAppFormGen
    {
        [Key]
        public int Id { get; set; }
        public string CommQ01 { get; set; }
        public string SpecQ11 { get; set; }
        public string SpecQ12 { get; set; }
    }
}

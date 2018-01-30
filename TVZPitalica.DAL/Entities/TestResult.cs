using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TVZPitalica.DAL.Entities
{
    public class TestResult
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Test")]
        public int TestId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public DateTime WriteDate { get; set; } = DateTime.Now;

        public virtual Test Test { get; set; }
    }
}

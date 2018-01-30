using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TVZPitalica.DAL.Entities
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int CreatorId { get; set; }
        public string TestName { get; set; }
        public int MaxScore { get; set; }
        public DateTime WriteDate { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }
}

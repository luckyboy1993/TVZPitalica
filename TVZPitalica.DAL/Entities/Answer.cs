using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TVZPitalica.DAL.Entities
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public int Row { get; set; }
        public int Score { get; set; }
        public string Definition { get; set; }
        public Boolean Type { get; set; }

        public virtual Question Question { get; set; }
    }
}

using SQLite;
using System;

namespace SpanMobile.Models
{
    [Table("Todo")]
    public class Todo
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public string Id { get; set; }
        [MaxLength()]
        public string TodoText { get; set; }
        public string TodoTime { get; set; }
        public string Done { get; set; }
    }
}
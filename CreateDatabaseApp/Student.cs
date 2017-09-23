using System;
using System.ComponentModel.DataAnnotations;

namespace CreateDatabaseApp
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")] 
        [RegularExpression("\\d{1,2}/\\d{1,2}/\\d{4}.*")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression("[0-3]\\.\\d{1,2}")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:9.99}")]
        public Decimal GPA { get; set; }
    }
}

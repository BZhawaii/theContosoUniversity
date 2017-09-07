using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace theContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [StringLength(50, ErrorMessage = "Name must be less than 50 characters")]
        [Display(Name = "Office Location")]
        public string Location { get; set; }


        public virtual Instructor Instructor { get; set; }
    }
}
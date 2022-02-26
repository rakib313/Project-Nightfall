﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nightfall.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "Please provide Valid for Email field")]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

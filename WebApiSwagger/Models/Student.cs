﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiSwagger.Models
{
    /// <summary>
    /// Student Model
    /// </summary>
    public class Student 
    {
        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
         [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name (Surname)
        /// </summary>
         [Required] 
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Birth Date
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

    }
}
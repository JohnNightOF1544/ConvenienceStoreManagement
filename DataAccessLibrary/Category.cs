﻿using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } 
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
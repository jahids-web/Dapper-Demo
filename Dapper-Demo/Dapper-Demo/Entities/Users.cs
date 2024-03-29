﻿using System.ComponentModel.DataAnnotations;

namespace Dapper_Demo.Entities
{
    public class Users
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}

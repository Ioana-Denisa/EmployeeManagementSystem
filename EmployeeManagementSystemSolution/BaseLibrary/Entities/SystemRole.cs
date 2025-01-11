﻿

using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class SystemRole
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
    }
}

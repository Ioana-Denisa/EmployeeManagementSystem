﻿

using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Country
    {
        public int ID {  get; set; }
        [Required]
        public string Name { get; set; }=string.Empty;
        public List<City>? Cities { get; set; }
    }   
}
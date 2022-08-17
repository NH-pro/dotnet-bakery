using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Never write code oustide of a class here

namespace DotnetBakery.Models
{
    public class Baker 
    {
        // PRIMARY KEY serial
        public int id {get; set;}

        [Required] // C# attribute, NOT NULL
        public string name {get; set;}
    }
}

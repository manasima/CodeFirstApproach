using System;
using System.ComponentModel.DataAnnotations;

namespace mis.data.Models
{
    public class Country
    {
        [Key]
        public Guid CountryId { get; set; }
        public string ISO_Code { get; set; }
        public string English_Name { get; set; }
    }
}
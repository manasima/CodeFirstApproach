using System;
using System.ComponentModel.DataAnnotations;

namespace mis.data.Models
{
    public class Member
    {
        [Key]
        public Guid MemberId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public Guid CountryId { get; set; }
        [Required(ErrorMessage = "InsertDate is required")]
        public Guid GenderId { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateOfBirth { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
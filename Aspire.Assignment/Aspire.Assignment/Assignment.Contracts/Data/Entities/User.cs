using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Contracts.Data.Entities;

public class User : BaseEntity
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string ?Username { get; set; }


    [Required]
    [MaxLength(255)]
    public string ?Password { get; set; }

   
    


  


}

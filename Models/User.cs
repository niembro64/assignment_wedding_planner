using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace assignment_wedding_planner.Models
{
  public class User
  {
    [Key]
    public int UserId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(255, MinimumLength = 8)]
    public string Password { get; set; }
    [NotMapped]
    [DataType(DataType.Password)]
    [StringLength(255, MinimumLength = 8)]
    [Compare("Password")]
    public string Confirm { get; set; }

    // navigation property
    public List<Reservation> WeddingList { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}
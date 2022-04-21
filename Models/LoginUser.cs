using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment_wedding_planner.Models
{
  public class LoginUser
  {
    [Required]
    [EmailAddress]
    public string LoginEmail { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(255, MinimumLength = 8)]
    public string LoginPassword { get; set; }
  }
}
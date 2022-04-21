using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace assignment_wedding_planner.Models
{
  public class Wedding
  {
    [Key]
    public int WeddingId { get; set; }
    [Required]
    public string WedderOne { get; set; }
    [Required]
    public string WedderTwo { get; set; }
    [Required]
    [CustomValidation(typeof(CustomValidationMethods), nameof(CustomValidationMethods.FutureDate))]
    // [CustomValidation(typeof(CustomValidationMethods), nameof(CustomValidationMethods.Not18))]
    public DateTime Date { get; set; }
    [Required]
    public string Address { get; set; }
    // navigation property
    public List<Reservation> UserList { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }

  public class CustomValidationMethods
  {
    public static ValidationResult FutureDate(DateTime date)
    {
      return DateTime.Compare(date, DateTime.Today) < 0 ? new ValidationResult("Date cannot be in the future") : ValidationResult.Success;
    }
    public static ValidationResult PastDate(DateTime date)
    {
      return DateTime.Compare(date, DateTime.Today) > 0 ? new ValidationResult("Date cannot be in the future") : ValidationResult.Success;
    }

    public static ValidationResult Not18(DateTime date)
    {
      DateTime today = DateTime.Today;
      return DateTime.Compare(date, DateTime.Today.AddYears(-18)) > 0 ? new ValidationResult("Must be at least 18") : ValidationResult.Success;
    }
  }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace assignment_wedding_planner.Models
{
  public class Reservation
  {
    [Key]
    public int ReservationId { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public int WeddingId { get; set; }
    public User User { get; set; }
    public Wedding Wedding { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // public Reservation(int w, int u)
    // {
    //   ResrvationId = 99;
    //   UserId = u;
    //   WeddingId = w;
    // }
  }
}
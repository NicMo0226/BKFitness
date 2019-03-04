using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.Models
{
  public class Session
  {
    public int Id { get; set; }

    [Required]
    [Display (Name = "Class")]
    public string SessionName { get; set; }

    [Required]
    public string SessionImageUrl { get; set; }

    [Required]
    [Display (Name = "Description")]
    public string SessionDescription { get; set; }

    [Required]
    [Display (Name = "Price")]
    [Column (TypeName = "decimal(18,2)")]
    public decimal ClassPriceNoMember { get; set; }

    [Display (Name = "Member Price")]
    [Column (TypeName = "decimal(18,2)")]
    public decimal ClassPriceMember { get; set; }

    // [NotMapped]
    // public virtual IEnumerable<Location> Locations { get; set; }

  }
}
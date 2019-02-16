using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BKFitness.Models
{
    public class Parq
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "House Number")]
        public int HouseNum { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2 (optional)")]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name = "Town")]
        public string Town { get; set; }

        [Required]
        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Contact Number")]
        public int TelNumber { get; set; }

        [Required]
        [Display(Name = "Emergency Contact (Name)")]
        public string ParqEmgncyContactName { get; set; }

        [Required]
        [Display(Name = "Emergency Contact (Tel)")]
        public int ParqEmgncyContactNumber { get; set; }

        [Required]
        public string ParqQuestion1 { get; set; }

        public string ParqQuestion1a { get; set; }

        [Required]
        public string ParqQuestion2 { get; set; }

        public string ParqQuestion2a { get; set; }

        [Required]
        public string ParqQuestion3 { get; set; }

        public string ParqQuestion3a { get; set; }

        [Required]
        public string ParqQuestion4 { get; set; }

        public string ParqQuestion4a { get; set; }

        [Required]
        public string ParqQuestion5 { get; set; }

        public string ParqQuestion5a { get; set; }

        [Required]
        public string ParqQuestion6 { get; set; }

        public string ParqQuestion6a { get; set; }

        [Required]
        public string ParqQuestion7 { get; set; }

        public string ParqQuestion7a { get; set; }

        [Required]
        public string ParqQuestion8 { get; set; }

        public string ParqQuestion8a { get; set; }

        [Required]
        public string ParqQuestion9 { get; set; }

        public string ParqQuestion9a { get; set; }

        [Required]
        public string ParqQuestion10 { get; set; }

        public string ParqQuestion10a { get; set; }

        [Required]
        public string ParqAgree { get; set; }

        [Required]
        public string ParqSignature { get; set; }
        

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }



    }
}
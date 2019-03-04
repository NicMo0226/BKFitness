using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BKFitness.ViewModels.Booking
{
  public class BookingListModel
  {
    public int Id { get; set; }
    public int SessionId { get; set; }
    public string SessionName { get; set; }
    public string SessionImageUrl { get; set; }
    public int LocationId { get; set; }
    public string LocationName { get; set; }
    public int DayDateId { get; set; }
    public string Day { get; set; }

    // [Display (Name = "Date")]
    // [DisplayFormat (DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
    public string ClassDate { get; set; }
    public int TimeId { get; set; }

    // [Display (Name = "Start Time")]
    // [DisplayFormat (DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    // [DataType (DataType.Time)]
    public string Start { get; set; }

    // [Display (Name = "End Time")]
    // [DisplayFormat (DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    // [DataType (DataType.Time)]
    public string End { get; set; }
    public decimal ClassPriceNoMember { get; set; }
    public decimal ClassPriceMember { get; set; }

  //  public string CurrentCategory { get; set; }

       

        }
    }

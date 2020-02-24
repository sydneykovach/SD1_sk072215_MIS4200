using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SD1_sk072215_MIS4200.Models
{
    public partial class Patient
    {
        public System.Guid SID { get; set; }
        public int PatientId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Patient First Name Required")]
        [StringLength(50)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Patient Last Name Required")]
        [StringLength(50)]
        public string lastName { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        [EmailAddress(ErrorMessage = "Email Address of Patient is required")]
        public string email { get; set; }

        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Please type the phone number using the following formats (xxx) xxx-xxxx OR xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "Date of Registration")]
        [DataType(DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> patientSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
    }
}
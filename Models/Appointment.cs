using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SD1_sk072215_MIS4200.Models
{
    public class Appointment
    {
        public System.Guid SID { get; set; }

        [Key]
        public int appointmentID { get; set; }

        [Display (Name = "Appointment Type (consultation, surgery, follow up)")]
        [Required]
        public string description { get; set; }

        [Display(Name = "Appointment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime appointmentDate { get; set; }

        [Display (Name = "Patient Name")]
        public int patientId { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }

        
        
       
        public virtual Patient Patient { get; set; }
    }
}
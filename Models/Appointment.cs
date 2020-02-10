using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SD1_sk072215_MIS4200.Models
{
    public class Appointment
    {

        [Key]
        public int appointmentID { get; set; }
        public string description { get; set; }
        public DateTime appointmentDate { get; set; }
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
        public int patientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
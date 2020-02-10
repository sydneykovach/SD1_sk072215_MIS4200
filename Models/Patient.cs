using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD1_sk072215_MIS4200.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime patientSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
    }
}
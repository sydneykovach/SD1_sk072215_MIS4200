using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SD1_sk072215_MIS4200.Models
{
    public class AppointmentDetail
    {

        public int appointmentDetailID { get; set; }

        [Display (Name = "# of Procedures Requested")]
        public int qtyProcedure { get; set; }

        [Display(Name = "Total Cost")]
        [DataType(DataType.Currency)]
        public decimal price { get; set; }
       

        // link appoitmentdetail to appointment:
        public int AppointmentID { get; set; }
        public virtual Appointment Appointment { get; set; }

        // link appoitmentdetail to procedure
        public int procedureId { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
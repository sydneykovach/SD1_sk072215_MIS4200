using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SD1_sk072215_MIS4200.Models
{
    public class Procedure
    {
        public System.Guid SID { get; set; }
        public int procedureID { get; set; }


        [Display(Name = "Procedure Name")]
        [Required]
        public string description { get; set; }

        [Display(Name = "Procedure Cost")]
        [DataType(DataType.Currency)]
        public decimal procedureCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }

        public int  doctorID { get; set; }


    }
}
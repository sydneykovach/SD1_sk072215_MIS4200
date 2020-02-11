using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SD1_sk072215_MIS4200.Models
{
    public class Procedure
    {
        public int procedureID { get; set; }
        public string description { get; set; }
        public decimal procedureCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }

        public int  doctorID { get; set; }


    }
}
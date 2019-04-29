using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int Gender { get; set; }        
        public bool IsSubscribedToNewsletter { get; set; }
        public MemberShipType MemberShipType { get; set; }// A navigation property    
        public byte MembershipTypeId { get; set; }//by convetion it will be regarded as foriegn key by entity framework        
        public DateTime? BirthDate { get; set; }
    }
}
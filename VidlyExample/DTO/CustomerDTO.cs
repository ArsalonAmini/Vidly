using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using VidlyExample.Models;

namespace VidlyExample.DTO
{
    public class CustomerDTO
    {

        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

       // [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}
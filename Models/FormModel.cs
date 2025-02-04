using System.ComponentModel;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;

namespace Amont_APPT.Models
{
    public class FormModel
    {

        public int Id { get; set; } // Primary Key

        [DisplayName("Ordre de Service")]
        public string OS { get; set; }

        [DisplayName("Prenom ")]

        public string FirstName { get; set; }

        [DisplayName("Nom  ")]
        public string LastName { get; set; }

        [DisplayName("Telephone ")]
        public string Phone { get; set; }

        [DisplayName("E-mail ")]
        public string Email { get; set; }

        [DisplayName("Addresse ")]
        public string Address { get; set; }

        [DisplayName("Ville   ")]
        public string City { get; set; }

        [DisplayName("Description ")]
        public string Description { get; set; }

        [DisplayName("Code Postal ")]
        public int ZipCode { get; set; }

 

    }
}

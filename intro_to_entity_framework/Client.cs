using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace intro_to_entity_framework
{
    [Table("Passangers")]
    internal class Client
    {
        //Primary Key naming : Id/id/ID/ EntityName+Id (ClientId)
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("FirstName")]
        public string Name { get; set; }
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime? Birthdate { get; set; }//value type null
        //null ---> not null
        //not null ---> null

        public int Rating { get; set; }

        //Relationship type : many to many (*...*)
        public ICollection<Flight> Flights { get; set; }
    }
}

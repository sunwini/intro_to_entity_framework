using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace intro_to_entity_framework
{
    internal class Flight
    {
        public int Number { get; set; }
        public string ArrivalCity { get; set; }
        public string DepartureCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        //Relationship type : many to many (*...*)
        public ICollection<Client> Clients { get; set; }

        //Relationship type : one to many (1...*)
        public Airplane Airplane { get; set; }

        //Forign key naming : RelatedEntityName + RelatedEntityNamePrimaryKey 
        public int AirplaneId { get; set; }//foreign key Airplane (Id)
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Meetup.Entities
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int CityId { get; set; }


        public City City { get; set; }
        public List<Participant> Participants { get; set; }

        public Meeting()
        {
            Participants = new List<Participant>();
        }
    }
}

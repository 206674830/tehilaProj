using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Meetup.Entities
{
    public class Participant
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}

using Meetup.DAL.Interfaces;
using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meetup.DAL.Services
{
    public class OptionDAL : IOptionDAL
    {
        private readonly MeetupDBContext _context;
        public OptionDAL(MeetupDBContext context)
        {
            _context = context;
        }
        public List<City> GetCities()
        {
            return _context.Cities.ToList(); 
        }
    }
}

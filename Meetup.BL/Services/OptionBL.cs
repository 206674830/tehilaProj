using Meetup.BL.Interfaces;
using Meetup.DAL.Interfaces;
using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.BL.Services
{
    public class OptionBL : IOptionBL
    {
        private readonly IOptionDAL _optionDAL;

        public OptionBL(IOptionDAL optionDAL)
        {
            _optionDAL = optionDAL;
        }

        public List<City> GetCities()
        {
            return this._optionDAL.GetCities();
        }
    }
}

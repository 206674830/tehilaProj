using Meetup.BL.Interfaces;
using Meetup.DAL.Interfaces;
using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meetup.BL.Services
{
    public class MeetingBL: IMeetingBL
    {
        private readonly IMeetingDAL _meetingDAL;

        public MeetingBL(IMeetingDAL meetingDAL)
        {
            _meetingDAL = meetingDAL;
        }

        public List<Meeting> GetAllMeetings()
        {
            return _meetingDAL.GetAllMeetings();
        }

        public List<Participant> GetMeetingParticipants(int meetingId)
        {
            return _meetingDAL.GetMeetingParticipants(meetingId);
        }

        public Meeting GetMeetingById(int meetingId)
        {
            return _meetingDAL.GetMeetingById(meetingId);
        }

        public List<Meeting> SearchMeeting(string search)
        {

            var meetings = GetAllMeetings();
            if (string.IsNullOrEmpty(search))
                return meetings;

            search = search.ToLower();
            return meetings.Where(x => x.Name.ToLower().Contains(search) ||
                                    x.City.Name.ToLower().Contains(search) || 
                                    x.Date.Date.ToString() == search).ToList();
        }
    }
}

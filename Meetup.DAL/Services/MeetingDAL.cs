using Meetup.DAL.Interfaces;
using Meetup.Entities;
using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meetup.DAL
{
    public class MeetingDAL : IMeetingDAL
    {
        private readonly MeetupDBContext _context;
        public MeetingDAL(MeetupDBContext context)
        {
            _context = context;
        }
        
        public List<Meeting> GetAllMeetings()
        {
            return _context.Meetings.ToList();
        }

        public List<Participant> GetMeetingParticipants(int meetingId)
        {
            return _context.Meetings.Where(x => x.Id == meetingId).FirstOrDefault()?.Participants;
        }

        public Meeting GetMeetingById(int meetingId)
        {
            return _context.Meetings.Where(x => x.Id == meetingId).FirstOrDefault();
        }
    }
}

using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.BL.Interfaces
{
    public interface IMeetingBL
    {
        List<Meeting> GetAllMeetings();
        List<Participant> GetMeetingParticipants(int meetingId);
        Meeting GetMeetingById(int meetingId);
        List<Meeting> SearchMeeting(string search);
    }
}

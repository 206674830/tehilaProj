using Meetup.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meetup.DAL.Interfaces
{
    public interface IMeetingDAL
    {
        List<Meeting> GetAllMeetings();
        List<Participant> GetMeetingParticipants(int meetingId);

        Meeting GetMeetingById(int meetingId);
    }
}

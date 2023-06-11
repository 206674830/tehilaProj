using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Meetup.BL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Meetup.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly IMeetingBL _meetingBL;
        public MeetingsController(IMeetingBL meetingBL)
        {
            _meetingBL = meetingBL;
        }

        [HttpGet("GetAllMeetings")]
        public IActionResult GetAllMeetings()
        {
            var meetings = _meetingBL.GetAllMeetings();
            return Ok(meetings);
        }

        [HttpGet("GetMeetingParticipants/{meetingId}")]
        public IActionResult GetMeetingParticipants(int meetingId)
        {
            var participants = _meetingBL.GetMeetingParticipants(meetingId);
            return Ok(participants);
        }

        [HttpGet("GetMeetingById/{meetingId}")]
        public IActionResult GetMeetingById(int meetingId)
        {
            var meeting = _meetingBL.GetMeetingById(meetingId);
            return Ok(meeting);
        }

        [HttpGet("searchMeeting/{search}")]
        public IActionResult SearchMeeting(string search)
        {
            var meetings = _meetingBL.SearchMeeting(search);
            return Ok(meetings);
        }


    }
}

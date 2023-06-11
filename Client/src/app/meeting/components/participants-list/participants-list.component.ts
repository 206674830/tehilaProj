import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Meeting } from 'src/app/models/meeting';
import { Participant } from 'src/app/models/participants';
import { MeetingService } from '../../services/meeting.service';

@Component({
  selector: 'app-participants-list',
  templateUrl: './participants-list.component.html',
  styleUrls: ['./participants-list.component.scss']
})
export class ParticipantsListComponent implements OnInit {

  meetingId: any;
  meeting!:Meeting;
  participants!: Observable<Participant[]>;

  constructor(private meetingService: MeetingService,
              private route:ActivatedRoute) { }

  ngOnInit(): void {

    this.route.paramMap.subscribe(params=>{
      this.meetingId =  params.get("id");
      this.meetingService.getMeetingById(+this.meetingId).subscribe(data=> {
        this.meeting=data;
      });
    //  this.participants = this.meetingService.getMeetingParticipants(+this.meetingId);
    })
  }

}

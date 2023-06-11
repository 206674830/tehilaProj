import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { City } from 'src/app/models/city';
import { Meeting } from 'src/app/models/meeting';
import { MeetingService } from '../../services/meeting.service';
import { OptionService } from '../../services/option.service';

@Component({
  selector: 'app-meetings-list',
  templateUrl: './meetings-list.component.html',
  styleUrls: ['./meetings-list.component.scss'],
  
})
export class MeetingsListComponent implements OnInit {

  meetings!: Meeting[];
  cities!: City[];
  
  freeSearch = '';
  searchName = '';
  searchCity!: '';
  searchDate!: Date;

  constructor(private meetingService: MeetingService,
    private optionService: OptionService) { }

  ngOnInit(): void {

    this.meetingService.getMeetings().subscribe((data)=>{
      this.meetings = data;
    });

    this.optionService.getCities().subscribe((data)=>{
      this.cities = data;
    })
  }

  search(){
    if(this.freeSearch)
      this.meetingService.searchMeeting(this.freeSearch)
      .subscribe(data=>{
        this.meetings = data;
      });
  }

}

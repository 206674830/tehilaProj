import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Meeting } from 'src/app/models/meeting';

@Component({
  selector: 'app-meeting',
  templateUrl: './meeting.component.html',
  styleUrls: ['./meeting.component.scss']
})
export class MeetingComponent implements OnInit {

  @Input()
  meeting!: Meeting;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

}

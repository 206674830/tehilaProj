import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Meeting } from 'src/app/models/meeting';
import { Participant } from 'src/app/models/participants';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MeetingService {

  private apiControllerName = 'Meetings'; 

  constructor(private http: HttpClient) { }

  getMeetings() : Observable<Meeting[]>{
    return this.http.get<Meeting[]>(`${environment.apiUrl}/${this.apiControllerName}/GetAllMeetings`);
  }

  getMeetingParticipants(meetingId: number): Observable<Participant[]>{
    return this.http.get<Participant[]>(`${environment.apiUrl}/${this.apiControllerName}/GetMeetingParticipants/${meetingId}`);
  }

  getMeetingById(meetingId: number): Observable<Meeting>{
    return this.http.get<Meeting>(`${environment.apiUrl}/${this.apiControllerName}/GetMeetingById/${meetingId}`);
  }

  searchMeeting(search: string): Observable<Meeting[]>{
    return this.http.get<Meeting[]>(`${environment.apiUrl}/${this.apiControllerName}/searchMeeting/${search}`);
  }

    
  
}

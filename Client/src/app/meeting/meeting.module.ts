import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MeetingRoutingModule } from './meeting-routing.module';
import { MeetingsListComponent } from './components/meetings-list/meetings-list.component';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { MeetingComponent } from './components/meeting/meeting.component';
import { ParticipantsListComponent } from './components/participants-list/participants-list.component';
import { ParticipantComponent } from './components/participant/participant.component';
import { FormsModule } from '@angular/forms';

import {ListboxModule} from 'primeng/listbox';
import { FilterPipe } from './pipes/filter.pipe';
import {CalendarModule} from 'primeng/calendar';
import {ButtonModule} from 'primeng/button'
import {DropdownModule} from 'primeng/dropdown';


@NgModule({
  declarations: [
    MeetingsListComponent,
    MeetingComponent,
    ParticipantsListComponent,
    ParticipantComponent,
    FilterPipe
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MeetingRoutingModule,
    FormsModule,
    ListboxModule,
    CalendarModule,
    DropdownModule,
    ButtonModule
  ],
})
export class MeetingModule { }

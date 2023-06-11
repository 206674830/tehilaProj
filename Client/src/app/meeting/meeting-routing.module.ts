import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MeetingsListComponent } from './components/meetings-list/meetings-list.component';
import { ParticipantsListComponent } from './components/participants-list/participants-list.component';

const routes: Routes = [
  {
    path: '',
    component: MeetingsListComponent
  },
  {
      path:':id/participants',
      component: ParticipantsListComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MeetingRoutingModule { }

import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'meetings',
    loadChildren: () => import('./meeting/meeting.module').then(m => m.MeetingModule)
  },
  {
    path: '',
    redirectTo:'meetings',
    pathMatch:'full'
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

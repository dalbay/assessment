import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProjectComponent } from './project/project.component';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(
    [
      { path: 'welcome', component: ProjectComponent },
      { path: '', redirectTo: 'welcome', pathMatch: 'full'}
    ]
  )],
  exports: [RouterModule]
})
export class AppRoutingModule { }

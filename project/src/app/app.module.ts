import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ProjectComponent } from './project/project.component';

@NgModule({
  declarations: [
    AppComponent,
    ProjectComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
  ],
  providers: [
   
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
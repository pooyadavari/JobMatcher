import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { CandidatesJobsComponent } from './candidates-jobs/candidates-jobs.component';


@NgModule({
  declarations: [
    AppComponent,
    CandidatesJobsComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

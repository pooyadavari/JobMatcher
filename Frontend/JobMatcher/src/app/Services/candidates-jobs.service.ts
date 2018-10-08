import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';
import { CandidateJob } from '../Models/CandidateJob';

@Injectable()
export class CandidatesJobsService {

  private baseApiAddress = 'http://localhost:53565/api/';
  private CandidatesJobsUrl = this.baseApiAddress + 'candidatesjobs';

  constructor(private http: HttpClient) { }

  getCandidatesJobs(): Observable<CandidateJob> {
    return this.http.get<CandidateJob>(this.CandidatesJobsUrl);
  }
}

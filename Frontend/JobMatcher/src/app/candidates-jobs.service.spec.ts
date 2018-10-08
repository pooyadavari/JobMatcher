import { TestBed, inject } from '@angular/core/testing';

import { CandidatesJobsService } from './candidates-jobs.service';

describe('CandidatesJobsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CandidatesJobsService]
    });
  });

  it('should be created', inject([CandidatesJobsService], (service: CandidatesJobsService) => {
    expect(service).toBeTruthy();
  }));
});

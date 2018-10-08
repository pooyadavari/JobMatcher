import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CandidatesJobsComponent } from './candidates-jobs.component';

describe('CandidatesJobsComponent', () => {
  let component: CandidatesJobsComponent;
  let fixture: ComponentFixture<CandidatesJobsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CandidatesJobsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CandidatesJobsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

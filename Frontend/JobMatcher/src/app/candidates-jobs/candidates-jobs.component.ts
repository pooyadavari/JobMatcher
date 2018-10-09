
import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import {MatPaginator, MatTableDataSource, MatSort} from '@angular/material';
import { CandidatesJobsService } from '../Services/candidates-jobs.service';

@Component({
  selector: 'app-candidates-jobs',
  templateUrl: './candidates-jobs.component.html',
  styleUrls: ['./candidates-jobs.component.css']
})
export class CandidatesJobsComponent implements OnInit, AfterViewInit {

  dataSourceResults: any;

  displayedColumns: string[] = ['jobName', 'jobCompany', 'candidateName' , 'jobSkills', 'candidateSkillTags'];
  candidatesJobsResults;
  isLoaded = true;

  constructor(private service: CandidatesJobsService) { }

  @ViewChild(MatPaginator) paginator: MatPaginator;
  // @ViewChild(MatSort) sort: MatSort;

  ngOnInit() {
    this.dataSourceResults = new MatTableDataSource(this.candidatesJobsResults);
  }

  ngAfterViewInit() {
    this.dataSourceResults.paginator = this.paginator;
    // this.dataSourceResults.sort = this.sort;
  }

  onSubmit() {

    this.isLoaded = false;

    this.service.getCandidatesJobs()
      .subscribe(response => {

        this.candidatesJobsResults = JSON.parse(JSON.stringify(response)); // .data;

        if (this.candidatesJobsResults.length > 0) {
          this.dataSourceResults.data = [];
          this.dataSourceResults.data = this.candidatesJobsResults;
          this.dataSourceResults.paginator = this.paginator;
          this.paginator._changePageSize(this.paginator.pageSize);
        }
      }, (error: Response) => {
        this.dataSourceResults.data = null;
        console.log(error);
      },
        () => {
          this.isLoaded = true;
        }
      );
  }


}

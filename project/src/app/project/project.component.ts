import { Component, OnInit } from '@angular/core';
import { DataService } from '../../services/http-service.service';
import { Project } from 'src/services/models/projects';
import { Observable, of } from 'rxjs';
@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit {

  constructor(private dataService: DataService) { }

  projects: any = [];
  ngOnInit(): void {
    this.dataService.getProjects()
      .subscribe(
        (data: Project[]) => this.projects = data,
        (err: any) => of(err)
    )
  }
}

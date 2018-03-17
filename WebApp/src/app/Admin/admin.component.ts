import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  adminmodules: string[] = ['Equipment', 'Audit', 'Incident', 'Development'];
  devactions =
  [{
    "action" : "Create New Module Specific Microservice",
    "url": "NewMicroservice"
    
  },
    {
      "action": "Create New Module UI Component",
      "url": "NewModuleUIComponent"
    }];
  constructor() { }

  ngOnInit() {
  }

}

import { Component, OnInit } from '@angular/core';


import { Router} from '@angular/router';
import { NewModuleTemplateService } from "./new-module-template.service";
import { ControlItem } from "../Common/control-item";

@Component({
  selector: 'my-app',
  templateUrl: './equipment.component.html',
  styleUrls: ['./equipment.component.css'],
  providers: [NewModuleTemplateService]
})
export class NewModuleTemplateComponent implements OnInit {

  title = 'Equipment Module';
  equipments: ControlItem[];
  selectedEquipment: ControlItem;
  response: string;

  constructor(
    private service: NewModuleTemplateService,
    private router: Router
  ) { }
  ngOnInit(): void {
      
  }

  onSelect(equipment: ControlItem): void {
      this.selectedEquipment = equipment;
  }

  gotoDetail(): void {
      //this.router.navigate(['/detail', this.selectedEquipment.assetNumber]);
  }

 
}

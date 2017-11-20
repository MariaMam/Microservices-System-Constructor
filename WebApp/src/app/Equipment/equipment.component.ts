import { Component, OnInit } from '@angular/core';

import { EquipmentItem, EquipmentEditItem } from './equipment-item';
import { EquipmentService } from './equipment.service';
import { Router} from '@angular/router';

@Component({
  selector: 'my-app',
  templateUrl: './equipment.component.html',
  styleUrls: ['./equipment.component.css'],
  providers: [EquipmentService]
})
export class EquipmentComponent implements OnInit {

  title = 'Equipment Module';
  equipments: EquipmentItem[];
  selectedEquipment: EquipmentItem;
  response: string;

  constructor(
      private equipmentService: EquipmentService,
      private router: Router,
  ) { }

  getEquipment(): void {

    //this.equipmentService.getEquipmentItemsJson().then(response => this.selectedHero = response);
    this.equipmentService.getEquipmentItems().subscribe(data => {
      console.log(data);
      this.equipments = data;
    });


  }

  ngOnInit(): void {
      this.getEquipment();
  }

  onSelect(equipment: EquipmentItem): void {
      this.selectedEquipment = equipment;
  }

  gotoDetail(): void {
      this.router.navigate(['/detail', this.selectedEquipment.assetNumber]);
  }

  /*add(name: string): void {
      name = name.trim();
      if (!name) { return; }
      this.equipmentService.create(name)
          .then(hero => {
              this.equipments.push(hero);
              this.selectedEquipment = null;
          });
  }

  delete(equipment: EquipmentItem): void {
      this.equipmentService
          .delete(equipment.assetNumber)
          .then(() => {
              this.equipments = this.equipments.filter(h => h !== equipment);
              if (this.selectedEquipment === equipment) { this.selectedEquipment = null; }


          });

  }

  edit(equipment: EquipmentItem): void {

      this.router.navigate(['/Edit/Equipment', this.selectedEquipment.equipmentItemId]);

  } */
}

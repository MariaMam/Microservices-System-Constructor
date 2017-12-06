import { Component, Input, OnInit, ViewContainerRef, NgModule, ViewChild, Inject } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import 'rxjs/add/operator/switchMap';
import { EquipmentItem, EquipmentEditItem } from "./equipment-item";
import { EquipmentService } from "./equipment.service";
import { Module, DataType } from "../../app.enum";
import { SimpleChanges } from '@angular/core';
import { Column } from "../../column-name";
import { ControlService } from "../Common/control.service";
import { ControlItem } from "../Common/control-item";
import { TextBoxComponent } from "../Common/text-box.component";

@Component({
  selector: 'my-edit',
  templateUrl: './edit.component.html'
})

export class EditComponent implements OnInit {
  @Input() equipment: EquipmentEditItem;
  service;
  service2;

  controls: ControlItem[];
  columnNames: Column[];
  id: string;
  val: any;


  @ViewChild('dynamic', {
    read: ViewContainerRef
  }) viewContainerRef: ViewContainerRef

  constructor(private equipmentService: EquipmentService,
    private route: ActivatedRoute,
    private location: Location, 
    viewContainerRef: ViewContainerRef, private controlService: ControlService) {

    this.service = ControlService;
    this.viewContainerRef = viewContainerRef;
  }

  ngOnInit(): void {
    var a = this.route.paramMap;
    var columnsWithValue;
    this.route.paramMap
      .switchMap((params: ParamMap) => this.equipmentService.getEquipmentItem(params.get('id')))
      .subscribe(equipment => {
        this.equipment = equipment
        this.updateFields()

      });
  }
  updateFields(): void {

    this.controlService.getControlConfigurationWithValues(Module.Equipment, this.equipment.EquipmentItemId).subscribe(data => {
      var controlItems = data
      console.log(controlItems);

      this.controls = controlItems.map(o => {
        this.val = o;

        if (this.val.DataType == DataType.String && !this.val.IsCustomField) {

          return new ControlItem(TextBoxComponent, { label: this.val.ColumnName, value: this.val.value })

        }
      }
      )
    });

  }

  goBack(): void {
    this.location.back();
  }

}




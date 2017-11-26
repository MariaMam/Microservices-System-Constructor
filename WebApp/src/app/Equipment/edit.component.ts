import { Component, Input, OnInit, ViewContainerRef, NgModule, ViewChild, Inject } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';
import 'rxjs/add/operator/switchMap';
import { EquipmentItem, EquipmentEditItem } from "./equipment-item";
import { EquipmentService } from "./equipment.service";
import { ControlItem } from "../Common/DynamicComponent3/control-item";
import { AdItem } from "../DynamicComponent2/ad-item";
import { Service } from "../DynamicComponent/service.service";
import { ControlService } from "../Common/DynamicComponent3/control.service";
import { AdService } from "../DynamicComponent2/ad.service";
import { Module, DataType } from "../../app.enum";
import { TextBoxComponent } from "../Common/DynamicComponent3/text-box.component";
import { SimpleChanges } from '@angular/core';
import { Column } from "../../column-name";

@Component({
  selector: 'my-edit',
  templateUrl: './edit.component.html'
})

export class EditComponent implements OnInit {
  @Input() equipment: EquipmentEditItem;
  service;
  service2;

  ads: AdItem[];
  controls: ControlItem[];
  columnNames: Column[];

  @ViewChild('dynamic', {
    read: ViewContainerRef
  }) viewContainerRef: ViewContainerRef

  constructor(private equipmentService: EquipmentService,
    private route: ActivatedRoute,
    private location: Location,
    //// @Inject(ControlService) controlService,      
    viewContainerRef: ViewContainerRef, private adService: AdService, private controlService: ControlService) {

    this.service = ControlService;
    this.viewContainerRef = viewContainerRef;
  }

  ngOnInit(): void {
    var a = this.route.paramMap;
    var columnsWithValue;
    this.route.paramMap
      .switchMap((params: ParamMap) => this.equipmentService.getEquipmentItem(params.get('id')))
      .subscribe(equipment => this.equipment = equipment);

    //this.service.setRootViewContainerRef(this.viewContainerRef)
    //this.service.addDynamicComponent(31)
    // this.ads = this.adService.getAds();
    //this.controls = this.controlService.getControls(Module.Equipment);
    this.controlService.getConfiguration(Module.Equipment).subscribe(data => {
      var controlItems = data
      console.log(controlItems);

      this.columnNames = controlItems.map(o => {
        o.data = o;
        if (o.data.dataType == DataType.String && !o.data.isCustomField) {
          return new Column(o.data.columnName);
        }
      }
      )



      this.controls = controlItems.map(o => {
        o.data = o;
        if (o.data.dataType == DataType.String && !o.data.isCustomField) {

          return new ControlItem(TextBoxComponent, { label: o.data.columnName })

        }
      }
      )
    });

  }

  goBack(): void {
    this.location.back();
  }





}

    /*save(): void {
        this.equipmentService.update(this.equipment)
            .then(() => this.goBack());
    }*/




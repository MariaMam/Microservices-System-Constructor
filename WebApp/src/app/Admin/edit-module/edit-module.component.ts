import { Component, Input, OnInit, ViewContainerRef } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Location } from '@angular/common';

import { DataType } from "../../../app.enum";
import { ControlItem } from "../../Common/control-item";
import { ControlService } from "../../Common/control.service";
import { TextBoxComponent } from "../../Common/text-box.component";
import { LabelComponent } from "../../Common/label.component";
import { SelectControlValueAccessor, FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-edit-module',
  templateUrl: './edit-module.component.html',
  styleUrls: ['./edit-module.component.css']
})
export class EditModuleComponent implements OnInit {

  module: string;
  config: any;
  controls: ControlItem[];
  controlsNotConfigured: ControlItem[];
  cnf: any;
  select: any;
  model: any;
  c: any;

  constructor(
    private route: ActivatedRoute,
    private location: Location,
    private controlService: ControlService,
    viewContainerRef: ViewContainerRef) {
  }

  ngOnInit() {

    var a = this.route.paramMap;
    var columnsWithValue;
    this.route.paramMap
      .switchMap((params: ParamMap) => this.controlService.getConfigurationSettings(params.get('module')))
      .subscribe(config => {
        this.config = config
        this.updateFields()

      });
  }

  compareFn(cnf1, cnf2): boolean {
    return cnf1 && cnf2 ? cnf1.ColumnName === cnf2.ColumnName : cnf1 === cnf2;
  }
  updateFields(): void {

    this.controls = this.config.map(o => {
      this.cnf = o;

      if (this.cnf.DataType == DataType.String) {

        return new ControlItem(LabelComponent, { label: this.cnf.ColumnName, value: this.cnf.DataType })

      }
    });

    
    /*this.controls = this.config.map(o => {
        this.cnf = o;
 
        if (this.cnf.DataType == DataType.String) {
 
          return new ControlItem(TextBoxComponent, { label: this.cnf.ColumnName, value: this.cnf.DataType})
 
        }*/



    console.log("Configured Controls : ");
    console.log(this.controls);

  }

  filterconfigs(type): any {
    if (this.config != null) {
      return this.config.filter(x => x.IsConfigured == type);
    }
  }

  add(): void {

    this.model.IsConfigured = true;
    console.log(this.config);
  
  }

  delete(conf): void {

    conf.IsConfigured = false;
    console.log(this.config);

  }
}



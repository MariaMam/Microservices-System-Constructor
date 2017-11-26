import { Injectable }           from '@angular/core';
import { ControlItem } from "./control-item";
import { TextBoxComponent } from "./text-box.component";
import { Observable } from "rxjs/Observable";
import { ControlItemModel } from "./module-control";
import { HttpClient } from "@angular/common/http";
import { DataType } from "../../../app.enum";
import { Column } from "../../../column-name";



@Injectable()
export class ControlService {
  private moduleConfigUrl = 'http://localhost:49983/api/moduleconfiguration';///api/equipment';
  apiVerison = 'api-version=1.0';
  controlItems: ControlItemModel[];
  controlComponents: ControlItem[];


  constructor(private http: HttpClient) { }

  /*return [
    new ControlItem(TextBoxComponent, {label: 'mylabel', value: 'Brave as they come'}),
    new ControlItem(TextBoxComponent, {label: 'mylabel2', value: 'Smart as they come'})
  ];*/



  getConfiguration(module: number): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetByModule?module=' + `${module}&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url);

  }

  getControlConfigurationWithValues(module: number, entityId:string): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetCntrlsWithValues?module=' + `${module}&` + "entityId=" + entityId +`&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url)

  }
}



import { Injectable }           from '@angular/core';
import { ControlItem } from "./control-item";
import { TextBoxComponent } from "./text-box.component";
import { Observable } from "rxjs/Observable";
import { HttpClient } from "@angular/common/http";
import { DataType } from "../../app.enum";
import { Column } from "../../column-name";
import { ControlItemModel } from "../Models/control-item-model";
import { HttpHeaders } from "@angular/common/http";



@Injectable()
export class ControlService {
  private moduleConfigUrl = 'http://localhost:49983/api/moduleconfiguration';///api/equipment';
  apiVerison = 'api-version=1.0';
  controlItems: ControlItemModel[];
  controlComponents: ControlItem[];


  constructor(private http: HttpClient) { }


  getConfiguration(module: number): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetByModule?module=' + `${module}&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url);

  }

  getControlConfigurationWithValues(module: number, entityId:string): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetCntrlsWithValues?module=' + `${module}&` + "entityId=" + entityId +`&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url)

  }

  geMLValues(module: number, entityId: string): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetCntrlsWithValues?module=' + `${module}&` + "entityId=" + entityId + `&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url)

  }

  getConfigurationSettings(module: string): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetModuleSettings?module=' + `${module}&${this.apiVerison}`;
    return this.http.get<ControlItemModel[]>(url);

  }
  saveModuleConfigurationSettings(module: string, config: any) {

    const url = `${this.moduleConfigUrl}/` + 'SaveModuleSettings?module=' + `${module}&${this.apiVerison}`;
    this.http
      .post('url', config)
      .subscribe();
  }
}



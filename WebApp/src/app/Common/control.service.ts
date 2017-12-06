import { Injectable }           from '@angular/core';
import { ControlItem } from "./control-item";
import { TextBoxComponent } from "./text-box.component";
import { Observable } from "rxjs/Observable";
import { HttpClient } from "@angular/common/http";
import { DataType } from "../../app.enum";
import { Column } from "../../column-name";
import { ControlItemModel } from "../Models/control-item-model";
import { HttpHeaders } from "@angular/common/http";
import { HttpParams } from "@angular/common/http";
import { RequestOptions } from "@angular/http";



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

  getControlConfigurationWithValues(module: number, entityId: string): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/` + 'GetCntrlsWithValues?module=' + `${module}&` + "entityId=" + entityId + `&${this.apiVerison}`;
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

   
    const url = `${this.moduleConfigUrl}/` + 'UpdateModuleSettings?module=' + `${module}&${this.apiVerison}`;
    /*this.http
      .post(this.moduleConfigUrl, config)
      .subscribe();*/
    var a = JSON.stringify(config);

    this.http.post(url, 
      config, {
        params: new HttpParams().set('config', a),
      
    }).subscribe();

    //this.http.post(url, a, { headers: new HttpHeaders().set('Content-Type', 'application/json') }).subscribe(
     
    //);
    /*this.http.post(url,
      config.toString()
    ).subscribe();*/
  }
}



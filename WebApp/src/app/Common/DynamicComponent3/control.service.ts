import { Injectable }           from '@angular/core';
import { ControlItem } from "./control-item";
import { TextBoxComponent } from "./text-box.component";
import { Observable } from "rxjs/Observable";
import { ControlItemModel } from "./module-control";
import { HttpClient } from "@angular/common/http";
import { DataType } from "../../../app.enum";


@Injectable()
export class ControlService {
  private moduleConfigUrl = 'http://localhost:49983/api/moduleconfiguration';///api/equipment';
  controlItems: ControlItemModel[];
  controlComponents: ControlItem[];
  constructor(private http: HttpClient) { }  

  getControls(module: number) {    

      this.getConfiguration(module).subscribe(data => {      
      this.controlItems = data;
    });

      return this.controlComponents = this.controlItems.map(o => {

        if (o.type == DataType.String) {          

          return new ControlItem(TextBoxComponent, { label: o.data.label, value: o.data.value })

          }
        
      });

   
    /*return [
      new ControlItem(TextBoxComponent, {label: 'mylabel', value: 'Brave as they come'}),
      new ControlItem(TextBoxComponent, {label: 'mylabel2', value: 'Smart as they come'})
    ];*/
  }


  getConfiguration(module: number): Observable<ControlItemModel[]> {

    const url = `${this.moduleConfigUrl}/${module}`;
    //var a = this.http.get<ControlItemModel[]>(url).switchMap();
    return this.http.get<ControlItemModel[]>(url);

    

  }
}

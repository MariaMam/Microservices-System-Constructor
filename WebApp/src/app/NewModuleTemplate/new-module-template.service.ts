import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { catchError, map, tap } from 'rxjs/operators';
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/toPromise';
import { ControlItem } from "../Common/control-item";

@Injectable()
export class NewModuleTemplateService {

  private newModuleTemplateUrl = 'http://localhost:49983/api/newModuleTemplateUrl'
  apiVerison = 'api-version=1.0';
    results: string;
    jsonresults: JSON;
    newModuleTemplateElements: ControlItem[];
    constructor(private http: HttpClient) { }    
        

    getEquipmentItems(): Observable<ControlItem[]>{

      const url = `${this.newModuleTemplateUrl}?${this.apiVerison}`;
      return this.http.get<ControlItem[]>(url)
        
    }

    getEquipmentItem(equipmentItemId: string): Observable<ControlItem>  {
      const url = `${this.newModuleTemplateUrl}/${equipmentItemId}?${this.apiVerison }`;

      return this.http.get<ControlItem>(url)
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }

    getEquipmentUrl(id: number): Observable<ControlItem> {
      const url = `${this.newModuleTemplateUrl}/${id}`;       

      return this.http.get<ControlItem>(url);
    }   
    
   private headers = new Headers({ 'Content-Type': 'application/json' });
    
   

}

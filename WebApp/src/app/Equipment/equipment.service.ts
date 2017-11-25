import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { EquipmentItem, EquipmentEditItem } from "./equipment-item";
import { catchError, map, tap } from 'rxjs/operators';
import { Observable } from "rxjs/Observable";
import 'rxjs/add/operator/toPromise';

@Injectable()
export class EquipmentService {

  private equipmentUrl = 'http://localhost:49983/api/equipment'
  apiVerison = 'api-version=1.0';
    results: string;
    jsonresults: JSON;
    resultsEquipment: EquipmentItem[];
    constructor(private http: HttpClient) { }    
        

    getEquipmentItems(): Observable<EquipmentItem[]>{

      const url = `${this.equipmentUrl}?${this.apiVerison}`;
      return this.http.get<EquipmentItem[]>(url)
        
    }

    getEquipmentItems2(): Promise<EquipmentItem[]> {             
      var eq;
      const url = `${this.equipmentUrl}?${this.apiVerison}`;
        var a = this.http.get(this.equipmentUrl).toPromise()         
            .then(res => {
                res as EquipmentItem[];
                console.log(res);
            });
         return this.http.get(this.equipmentUrl)
             .toPromise()
             .then(res => res as EquipmentItem[]);
         
    }    

    getEquipmentItem(equipmentItemId: string): Observable<EquipmentEditItem>  {
      const url = `${this.equipmentUrl}/${equipmentItemId}? ${this.apiVerison }`;

      return this.http.get<EquipmentEditItem>(url)
    }

    getEquipmentItem2(equipmentItemId: string): Promise<EquipmentEditItem> {
        
        const url = `${this.equipmentUrl}/${equipmentItemId}`;

        var a = this.http.get(url).toPromise()
            .then(res => {
                console.log(res);
                res as EquipmentEditItem;                
            });
        return this.http.get(url)
            .toPromise()
            .then(response => response as EquipmentEditItem)
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }

    getEquipmentUrl(id: number): Observable<EquipmentItem> {
      const url = `${this.equipmentUrl}/${id}`;       

      return this.http.get<EquipmentItem>(url);
    }   
    
   private headers = new Headers({ 'Content-Type': 'application/json' });
    
   /*update(hero: EquipmentItem): Promise<EquipmentItem> {
       const url = `${this.equipmentUrl}/${hero.assetNumber}`;      
        return this.http
            .put(url, JSON.stringify(hero), { headers: this.headers })
            .toPromise()
            .then(() => hero)
            .catch(this.handleError);
    }
   create(name: string): Promise<EquipmentItem> {
        return this.http
            .post(this.equipmentUrl, JSON.stringify({ name: name }), { headers: this.headers })
            .toPromise()
            .then(res => res.json().data as EquipmentItem)
            .catch(this.handleError);
    }

    delete(id: string): Promise<void> {
        const url = `${this.equipmentUrl}/${id}`;
        return this.http.delete(url, { headers: this.headers })
            .toPromise()
            .then(() => null)
            .catch(this.handleError);
    }*/

}

import { Component, OnInit } from '@angular/core';
import { ModuleEnum } from "../Enums";
import { Globals } from "../../globals";



@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css'],
  providers: [Globals]
})
export class MenuComponent implements OnInit {   

    module = this.globals.moduleEnums;
    /*modelues
    : Array<MenuItem> {
        for(let i in ModuleEnum)
        var keys = Object.keys(this.module);
        return keys.slice(keys.length / 2);
    }*/
    
    constructor(private globals: Globals) { }

  ngOnInit() {
  }

}

export class MenuItem {

    Name:string;
    Id:string;  
    constructor() { }
   
}

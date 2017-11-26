import { Component, OnInit, SimpleChanges } from '@angular/core';
import { Module } from "../../Models/Module";
import { Router } from '@angular/router';

@Component({
  selector: 'app-config-builder',
  templateUrl: './config-builder.component.html',
  styleUrls: ['./config-builder.component.css']
})
export class ConfigBuilderComponent implements OnInit {

  modules: any;
  


  constructor() {
    let a = new Module("31", "Equipment");
    this.modules = [a];
  }

  ngOnInit() {
  }

  ngOnChanges(changes: SimpleChanges) {  }
}

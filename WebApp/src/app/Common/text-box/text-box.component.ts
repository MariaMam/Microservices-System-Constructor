import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'text-box',
  inputs: ['label', 'value'],
  templateUrl: './text-box.component.html',
  styleUrls: ['./text-box.component.css']
})
export class TextBoxComponent {
  label = 'static label'
  value = 'static value'
  @Input() values: string[];

  constructor() {
   
  }

  ngAfterViewInit() {
    this.loadComponent();   
  }

  loadComponent() {
    this.label = this.values[0];
    this.value = this.values[1];
  }
  @Input() set appUnless(values: string[]) {
    this.label = values[0];
    this.value = values[1];

  }
}

import { Component, Input }  from '@angular/core';
import { ControlComponent } from "./Control.component";


@Component({
  template: `
    <div class="hero-profile">      
      <h4>{{data.label}}</h4>      
      <p>{{data.value}}</p>
    </div>
  `
})
export class TextBoxComponent implements ControlComponent {
  @Input() data: any;
}



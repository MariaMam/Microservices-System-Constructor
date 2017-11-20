import { Component, Input } from '@angular/core';
import { ControlComponent } from "./Control.component";


@Component({
  template: `
    <div class="job-ad">
      <h4>{{data.headline}}</h4> 
      
      {{data.body}}
    </div>
  `
})
export class HeroJobAdComponent implements ControlComponent {
  @Input() data: any;

}


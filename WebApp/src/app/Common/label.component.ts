import { Component, Input }  from '@angular/core';
import { ControlComponent } from "./Control.component";


@Component({
  template: `
    <div class="hero-profile">
    <table>
    <tr>
    <td><h4> {{data.label}}</h4></td>
    <td align="center" ><h4> {{data.value}}</h4></td>
    </tr>
    </table>
    </div>
  `,
  styleUrls: ['./style.component.css']
})

export class LabelComponent implements ControlComponent {
  @Input() data: any;

}



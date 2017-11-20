import { Injectable }           from '@angular/core';
import { ControlItem } from "./control-item";
import { TextBoxComponent } from "./text-box.component";


@Injectable()
export class ControlService {
  getControls() {
    return [
      new ControlItem(TextBoxComponent, {label: 'mylabel', value: 'Brave as they come'}),

      new ControlItem(TextBoxComponent, { label: 'mylabel2', value: 'Smart as they come'})
    ];
  }
}

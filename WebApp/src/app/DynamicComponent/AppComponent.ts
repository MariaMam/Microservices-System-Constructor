import {   Component,   Inject,  ViewContainerRef} from '@angular/core'
import { Service } from "./Service.service";


@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1>`
})

export class AppComponent {
  name = 'from Angular'
  constructor(@Inject(Service) service, 

    @Inject(ViewContainerRef) viewContainerRef) {

    service.setRootViewContainerRef(viewContainerRef)
    service.addDynamicComponent()
  }
}

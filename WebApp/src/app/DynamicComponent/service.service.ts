import { ComponentFactoryResolver,  Injectable,  Inject,  ReflectiveInjector} from '@angular/core'
import { DynamicComponent } from './dynamic.component'
import { TextBoxComponent } from "../Common/DynamicComponent3/text-box.component";

@Injectable()
export class Service {

  factoryResolver: ComponentFactoryResolver;
  rootViewContainer;

  constructor( @Inject(ComponentFactoryResolver) factoryResolver) {
    this.factoryResolver = factoryResolver
  }
  setRootViewContainerRef(viewContainerRef) {
    this.rootViewContainer = viewContainerRef
  }
  addDynamicComponent(module=-1) {

    if (module == 31) {
      const factory = this.factoryResolver
        .resolveComponentFactory(TextBoxComponent)
      const component = factory
        .create(this.rootViewContainer.parentInjector)
      this.rootViewContainer.insert(component.hostView)
    }
    else {
      const factory = this.factoryResolver
        .resolveComponentFactory(DynamicComponent)
      const component = factory
        .create(this.rootViewContainer.parentInjector)
      this.rootViewContainer.insert(component.hostView)
    }
  }
}

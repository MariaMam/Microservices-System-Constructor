import { Component, Input, AfterViewInit, ViewChild, ComponentFactoryResolver, OnDestroy, SimpleChanges } from '@angular/core';
import { ControlItem } from './control-item';
import { ControlDirective } from './control.directive';
import { ControlComponent } from './control.component';


@Component({
  selector: 'control-box',
  template: `
              <div class="cntrl-box">
                <h3>Module Controls</h3>
                <ng-template control-host></ng-template>
              </div>
            `
})
export class ControlBoxComponent implements AfterViewInit {

 @Input() controls: ControlItem[];  
  @ViewChild(ControlDirective) controlHost: ControlDirective;
  subscription: any;
  

  constructor(private componentFactoryResolver: ComponentFactoryResolver) { }

  ngAfterViewInit() {
    this.loadComponent();    
  }
  

  loadComponent() {   
    
    for (let controlItem of this.controls) {
   
      let componentFactory = this.componentFactoryResolver.resolveComponentFactory(controlItem.component);
      let viewContainerRef = this.controlHost.viewContainerRef;
      let componentRef = viewContainerRef.createComponent(componentFactory);
      (<ControlComponent>componentRef.instance).data = controlItem.data;

    }   
  }

  ngOnChanges(changes: SimpleChanges) {
    this.loadComponent();
    }

  
}

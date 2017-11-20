import { Component, Input, AfterViewInit, ViewChild, ComponentFactoryResolver, OnDestroy } from '@angular/core';
import { ControlItem } from "./control-item";
import { ControlDirective } from "./Control.directive";
import { ControlComponent } from "./Control.component";


@Component({
  selector: 'app-add-banner',
  template: `
              <div class="ad-banner">
                <h3>Advertisements</h3>
                <ng-template ad-host></ng-template>
              </div>
            `
})
export class ControlBoxComponent implements AfterViewInit {

 @Input() cntrls: ControlItem[];  
  @ViewChild(ControlDirective) adHost: ControlDirective;
  subscription: any;
  

  constructor(private componentFactoryResolver: ComponentFactoryResolver) { }

  ngAfterViewInit() {
    this.loadComponent();
    this.getAds();
  }
  

  loadComponent() {   
    
    for (let controlItem of this.cntrls) {
   
      let componentFactory = this.componentFactoryResolver.resolveComponentFactory(controlItem.component);
      let viewContainerRef = this.adHost.viewContainerRef;
      let componentRef = viewContainerRef.createComponent(componentFactory);
      (<ControlComponent>componentRef.instance).data = controlItem.data;

    }   
  }

  getAds() {
    
      this.loadComponent();
   
  }
}

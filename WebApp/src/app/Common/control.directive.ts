import { Directive, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[control-host]',
})
export class ControlDirective {
  constructor(public viewContainerRef: ViewContainerRef) { }
}


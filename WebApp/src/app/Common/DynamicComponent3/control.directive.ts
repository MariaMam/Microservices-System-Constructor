import { Directive, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[ad-host]',
})
export class ControlDirective {
  constructor(public viewContainerRef: ViewContainerRef) { }
}


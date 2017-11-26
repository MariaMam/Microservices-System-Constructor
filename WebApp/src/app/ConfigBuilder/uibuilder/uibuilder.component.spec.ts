import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UibuilderComponent } from './uibuilder.component';

describe('UibuilderComponent', () => {
  let component: UibuilderComponent;
  let fixture: ComponentFixture<UibuilderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UibuilderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UibuilderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

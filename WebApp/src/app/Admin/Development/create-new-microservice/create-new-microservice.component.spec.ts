import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateNewMicroserviceComponent } from './create-new-microservice.component';

describe('CreateNewMicroserviceComponent', () => {
  let component: CreateNewMicroserviceComponent;
  let fixture: ComponentFixture<CreateNewMicroserviceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateNewMicroserviceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateNewMicroserviceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

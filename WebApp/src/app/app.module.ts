import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard.component';
import { EquipmentComponent } from './Equipment/equipment.component';
import { EditComponent } from './Equipment/edit.component';
import { EquipmentService} from './Equipment/equipment.service';
import { HttpClientModule } from '@angular/common/http';
import { MenuComponent } from './menu/menu.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AdminComponent } from './admin/admin.component';
import { EditModuleComponent } from './Admin/edit-module/edit-module.component';
import { ControlBoxComponent } from "./Common/control-box.component";
import { ControlDirective } from "./Common/control.directive";
import { TextBoxComponent } from "./Common/text-box.component";
import { ControlService } from "./Common/control.service";
import { LabelComponent } from "./Common/label.component";
import { CreateNewMicroserviceComponent } from './Admin/Development/create-new-microservice/create-new-microservice.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        AppRoutingModule,
        HttpClientModule,        
        BrowserAnimationsModule
        
        
    ],
    declarations: [
        AppComponent,
        DashboardComponent,
        EquipmentComponent,
        MenuComponent,
        EditComponent,     
        ControlBoxComponent,
        ControlDirective,
        TextBoxComponent,
        AdminComponent,
      EditModuleComponent,
      LabelComponent,
      CreateNewMicroserviceComponent
    ],
    providers: [EquipmentService,ControlService],
    bootstrap: [AppComponent],
    entryComponents: [TextBoxComponent, LabelComponent]
})
export class AppModule { }

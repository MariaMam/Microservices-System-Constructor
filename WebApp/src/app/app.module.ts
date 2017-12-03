import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard.component';
import { HeroesComponent } from './heroes.component';
import { HeroDetailComponent } from './hero-detail.component';
import { HeroService } from './hero.service';
import { HeroSearchComponent } from './hero-search.component';
import { EquipmentComponent } from './Equipment/equipment.component';
import { EditComponent } from './Equipment/edit.component';
import { EquipmentService} from './Equipment/equipment.service';
import { HttpClientModule } from '@angular/common/http';
import { MenuComponent } from './menu/menu.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AdBannerComponent } from "./DynamicComponent2/ad-banner.component";
import { HeroJobAdComponent } from "./DynamicComponent2/hero-job-ad.component";
import { HeroProfileComponent } from "./DynamicComponent2/hero-profile.component";
import { AdDirective } from "./DynamicComponent2/ad.directive";
import { AdService } from "./DynamicComponent2/ad.service";
import { AdminComponent } from './admin/admin.component';
import { EditModuleComponent } from './Admin/edit-module/edit-module.component';
import { ControlBoxComponent } from "./Common/control-box.component";
import { ControlDirective } from "./Common/control.directive";
import { TextBoxComponent } from "./Common/text-box.component";
import { ControlService } from "./Common/control.service";
import { LabelComponent } from "./Common/label.component";

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
        HeroDetailComponent,
        HeroesComponent,
        HeroSearchComponent,
        EquipmentComponent,
        MenuComponent,
        EditComponent,     
        AdBannerComponent,
        HeroJobAdComponent,
        HeroProfileComponent,
        AdDirective,
        ControlBoxComponent,
        ControlDirective,
        TextBoxComponent,
        AdminComponent,
      EditModuleComponent,
      LabelComponent
    ],
    providers: [HeroService, EquipmentService, AdService,ControlService],
    bootstrap: [AppComponent],
    entryComponents: [TextBoxComponent, HeroJobAdComponent, HeroProfileComponent, LabelComponent]
})
export class AppModule { }

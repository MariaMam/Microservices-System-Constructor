import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

// Imports for loading & configuring the in-memory web api
//import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService } from './in-memory-data.service';

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
import { DynamicComponent } from "./DynamicComponent/dynamic.component";
import { Service } from "./DynamicComponent/Service.service";
import { TextBoxComponent } from "./Common/DynamicComponent2/text-box.component";
import { AdBannerComponent } from "./DynamicComponent2/ad-banner.component";
import { HeroJobAdComponent } from "./DynamicComponent2/hero-job-ad.component";
import { HeroProfileComponent } from "./DynamicComponent2/hero-profile.component";
import { AdDirective } from "./DynamicComponent2/ad.directive";
import { AdService } from "./DynamicComponent2/ad.service";
import { ControlBoxComponent } from "./Common/DynamicComponent2/control-box.component";
import { ControlDirective } from "./Common/DynamicComponent2/control.directive";
import { ControlService } from "./Common/DynamicComponent2/control.service";

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        //InMemoryWebApiModule.forRoot(InMemoryDataService, { dataEncapsulation: true }),
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
        DynamicComponent,        
        AdBannerComponent,//
        HeroJobAdComponent,
        HeroProfileComponent,
        AdDirective,
        ControlBoxComponent,
        ControlDirective,
        TextBoxComponent
    ],
    providers: [HeroService, EquipmentService, Service, AdService,ControlService],
    bootstrap: [AppComponent],
    entryComponents: [DynamicComponent, TextBoxComponent, HeroJobAdComponent, HeroProfileComponent]
})
export class AppModule { }

"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var app_routing_module_1 = require("./app-routing.module");
// Imports for loading & configuring the in-memory web api
//import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService } from './in-memory-data.service';
var app_component_1 = require("./app.component");
var dashboard_component_1 = require("./dashboard.component");
var heroes_component_1 = require("./heroes.component");
var hero_detail_component_1 = require("./hero-detail.component");
var hero_service_1 = require("./hero.service");
var hero_search_component_1 = require("./hero-search.component");
var equipment_component_1 = require("./Equipment/equipment.component");
var edit_component_1 = require("./Equipment/edit.component");
var equipment_service_1 = require("./Equipment/equipment.service");
var http_2 = require("@angular/common/http");
var menu_component_1 = require("./menu/menu.component");
var animations_1 = require("@angular/platform-browser/animations");
var textbox_1 = require("./directives/textbox");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            forms_1.FormsModule,
            http_1.HttpModule,
            //InMemoryWebApiModule.forRoot(InMemoryDataService, { dataEncapsulation: true }),
            app_routing_module_1.AppRoutingModule,
            http_2.HttpClientModule,
            animations_1.BrowserAnimationsModule
        ],
        declarations: [
            app_component_1.AppComponent,
            dashboard_component_1.DashboardComponent,
            hero_detail_component_1.HeroDetailComponent,
            heroes_component_1.HeroesComponent,
            hero_search_component_1.HeroSearchComponent,
            equipment_component_1.EquipmentComponent,
            menu_component_1.MenuComponent,
            edit_component_1.EditComponent,
            textbox_1.TextBox
        ],
        providers: [hero_service_1.HeroService, equipment_service_1.EquipmentService],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map
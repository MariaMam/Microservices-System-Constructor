"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var globals_1 = require("../../globals");
var MenuComponent = (function () {
    /*modelues
    : Array<MenuItem> {
        for(let i in ModuleEnum)
        var keys = Object.keys(this.module);
        return keys.slice(keys.length / 2);
    }*/
    function MenuComponent(globals) {
        this.globals = globals;
        this.module = this.globals.moduleEnums;
    }
    MenuComponent.prototype.ngOnInit = function () {
    };
    return MenuComponent;
}());
MenuComponent = __decorate([
    core_1.Component({
        selector: 'app-menu',
        templateUrl: './menu.component.html',
        styleUrls: ['./menu.component.css'],
        providers: [globals_1.Globals]
    }),
    __metadata("design:paramtypes", [globals_1.Globals])
], MenuComponent);
exports.MenuComponent = MenuComponent;
var MenuItem = (function () {
    function MenuItem() {
    }
    return MenuItem;
}());
exports.MenuItem = MenuItem;
//# sourceMappingURL=menu.component.js.map
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
var equipment_service_1 = require("./equipment.service");
var router_1 = require("@angular/router");
var EquipmentComponent = (function () {
    function EquipmentComponent(equipmentService, router) {
        this.equipmentService = equipmentService;
        this.router = router;
        this.title = 'Equipment Module';
    }
    EquipmentComponent.prototype.getEquipment = function () {
        var _this = this;
        //this.equipmentService.getEquipmentItemsJson().then(response => this.selectedHero = response);
        this.equipmentService.getEquipmentItems()
            .then(function (equipments) { return _this.equipments = equipments; }).then();
    };
    EquipmentComponent.prototype.ngOnInit = function () {
        this.getEquipment();
    };
    EquipmentComponent.prototype.onSelect = function (equipment) {
        this.selectedEquipment = equipment;
    };
    EquipmentComponent.prototype.gotoDetail = function () {
        this.router.navigate(['/detail', this.selectedEquipment.assetNumber]);
    };
    return EquipmentComponent;
}());
EquipmentComponent = __decorate([
    core_1.Component({
        selector: 'my-app',
        templateUrl: './equipment.component.html',
        styleUrls: ['./equipment.component.css'],
        providers: [equipment_service_1.EquipmentService]
    }),
    __metadata("design:paramtypes", [equipment_service_1.EquipmentService,
        router_1.Router])
], EquipmentComponent);
exports.EquipmentComponent = EquipmentComponent;
//# sourceMappingURL=equipment.component.js.map
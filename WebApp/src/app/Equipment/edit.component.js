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
var router_1 = require("@angular/router");
var common_1 = require("@angular/common");
require("rxjs/add/operator/switchMap");
var equipment_item_1 = require("./equipment-item");
var equipment_service_1 = require("./equipment.service");
var EditComponent = (function () {
    function EditComponent(equipmentService, route, location) {
        this.equipmentService = equipmentService;
        this.route = route;
        this.location = location;
    }
    EditComponent.prototype.ngOnInit = function () {
        var _this = this;
        var a = this.route.paramMap;
        this.route.paramMap
            .switchMap(function (params) { return _this.equipmentService.getEquipmentItem(params.get('id')); })
            .subscribe(function (equipment) { return _this.equipment = equipment; });
    };
    EditComponent.prototype.goBack = function () {
        this.location.back();
    };
    return EditComponent;
}());
__decorate([
    core_1.Input(),
    __metadata("design:type", equipment_item_1.EquipmentEditItem)
], EditComponent.prototype, "equipment", void 0);
EditComponent = __decorate([
    core_1.Component({
        selector: 'hero-detail',
        templateUrl: './edit.component.html',
        styleUrls: ['./hero-detail.component.css']
    }),
    __metadata("design:paramtypes", [equipment_service_1.EquipmentService,
        router_1.ActivatedRoute,
        common_1.Location])
], EditComponent);
exports.EditComponent = EditComponent;
//# sourceMappingURL=edit.component.js.map

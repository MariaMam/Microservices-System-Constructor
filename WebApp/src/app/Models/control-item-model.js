"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var TableItem = (function () {
    function TableItem() {
    }
    return TableItem;
}());
exports.TableItem = TableItem;
var EquipmentItem = (function () {
    function EquipmentItem() {
    }
    return EquipmentItem;
}());
exports.EquipmentItem = EquipmentItem;
var EquipmentEditItem = (function (_super) {
    __extends(EquipmentEditItem, _super);
    function EquipmentEditItem() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    return EquipmentEditItem;
}(EquipmentItem));
exports.EquipmentEditItem = EquipmentEditItem;
//# sourceMappingURL=equipment-item.js.map
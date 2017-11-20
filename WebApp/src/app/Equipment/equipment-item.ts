export class TableItem {
    assetNumber: string;
    name: string;
    equipmentItemId: string;
}
export class EquipmentItem {
  assetNumber: string;
  name: string;
  equipmentItemId: string;
}

export class EquipmentEditItem extends EquipmentItem {
    
    description: string;
    disposalDate: Date;
    manufactureUesr: number;
    adressCountry: string;
    adressCity: string;
    adressArealText: string;
    adressDistrictText: string   
}

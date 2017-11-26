export class Column {
  table: string;
  column: string;
  value: string;
  columnName: string;
  constructor(input: string) {
    this.columnName = input;
    var array = input.split('.');
    this.table = array[0];
    this.column = array[1];

  }
}

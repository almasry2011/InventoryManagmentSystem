export interface WarehouseModel {
  name: string;
  locationStreet: string;
  locationCity: string;
  locationState: string;
  locationZipCode: string;
  locationCountry: string;
  bins: Bin[];
  binsNumbers: number;
  location: string;
  productsCount: number;
  productsPrice: number;

  id: number;


}


export interface Bin {
  name?: string;
  serialNumber?: string;
  color?: string;
  width?: number;
  depth?: number;
  height?: number;
  dividerSlots?: number;
  weight?: number;
  warehouseId?: number;
  id?: number;
}

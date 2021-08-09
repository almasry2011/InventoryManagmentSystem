import { Data } from '@angular/router';
import { data } from 'jquery';
import { ProductDetail } from "./ProductDetail";

export interface ProductModel {
  id?: number;
  name?: string;
  productCode?: string;
  description?: string;
  numberInStock?: number;
  productCategoryId?: number;
  warehouseId?: number;
  warehouseBinId?: number;
  sellingUnitPrice?: number;
  sellingBoxPrice?: number;
  boxPriceWholeSale?: number;
  unitPriceWholeSale?: number;
  expiryDate?: Data;
  itemsInBox?: number;
  productCategoryStr?: string;
  warehouseStr?: string;
  warehouseBinStr?: string;
  segmentalProfit?: number;
  wholesaleProfit?: number;
  avalableBoxs?: number;
  singleItems?: number;
  //_productDetails?: ProductDetail[];










}




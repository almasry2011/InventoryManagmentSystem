import { ProductModel } from "./product-model";

export interface ProductDetail {
  id: number;
  productName: string;

  productId: number;
  productDetailsId: number;
  unitPrice: number;
  sellingPrice: number;
  buyingPrice: number;
  productCode: string;
  description: string;
  boxNumber: number;
  itemsInBox: number;
  boxPrice: number;
  productionDate: Date;
  expiryDate: Date;

  calculatedUnitPrice: number;

  wholesaleBoxProfit: number;
  wholesaleProfit: number;
  segmentalProfit: number;

  stock: number;



  wholesaleUnitPrice: number;
  segmentalUnitPrice: number;


  sellingBoxPrice: number;
  sellingUnitPrice: number;


  rowStatus: string;

  Product: ProductModel;

}

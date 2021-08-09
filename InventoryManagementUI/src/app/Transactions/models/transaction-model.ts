import { ProductModel } from './../../products/models/product-model';
import { PartnerModel } from './../../partners/models/partner-model';
export interface TransactionModel {
  total: number;
  transactionType: number;
  transactionTypeId: number;
  transactionTypeStr: string;
  partnerId: number;
  partnerName: string;
  partner: PartnerModel;
  _TransactionLines: TransactionLine[];
  id: number;
  productsCount: number;
  phoneNumber: string;
  transactionDate: Date;

  segmentalProfit: number;

  wholesaleProfit: number;
  profit: number;

}

export interface TransactionLine {
  id?: number;
  transactionId?: number;
  productId?: number;
  productName?: string;
  quantity?: number;
  unitPrice?: number;
  product?: ProductModel;


  buyingBoxPrice?: number;
  buyingUnitPrice?: number;
  sellingUnitPrice?: number;
  sellingBoxPrice?: number;
  total?: number;
  profit?: number;
  box?: boolean;




}






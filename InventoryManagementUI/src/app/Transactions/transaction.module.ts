
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TransactionRoutingModule } from './transaction-routing.module';
import { TransactionFormComponent } from './components/transaction-form/transaction-form.component';
import { TransactionIndexComponent } from './components/transaction-index/transaction-index.component';
import { SharedModule } from '../shared/shared.module';
import { TransactionCreateComponent } from './components/transaction-create/transaction-create.component';
import { SaleComponent } from './components/sale/sale.component';
import { PurchaseComponent } from './components/purchase/purchase.component';
import { TransactionlineFormFormComponent } from './components/transactions-line-form/transactions-line-form.component';



@NgModule({
  declarations: [TransactionFormComponent, TransactionlineFormFormComponent, TransactionIndexComponent, TransactionCreateComponent, SaleComponent, PurchaseComponent],
  imports: [
    CommonModule,
    TransactionRoutingModule,
    SharedModule
  ]
})
export class TransactionModule { }

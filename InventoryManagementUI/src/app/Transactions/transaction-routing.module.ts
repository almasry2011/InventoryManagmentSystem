import { PurchaseComponent } from './components/purchase/purchase.component';
import { SaleComponent } from './components/sale/sale.component';
import { TransactionCreateComponent } from './components/transaction-create/transaction-create.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TransactionIndexComponent } from './components/transaction-index/transaction-index.component';

const routes: Routes = [

  { path: '', component: TransactionIndexComponent },

  { path: "add", component: TransactionCreateComponent },
  { path: "sale", component: SaleComponent },

  { path: "purchase", component: PurchaseComponent },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TransactionRoutingModule { }

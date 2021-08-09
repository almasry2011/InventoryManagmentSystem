
import { ForbiddenComponent } from './core/components/forbidden/forbidden.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './core/components/page-not-found/page-not-found.component';

const routes: Routes = [
  { path: 'auth', loadChildren: () => import('./core/Auth/auth.module').then((m) => m.AuthModule) },
  { path: 'product', loadChildren: () => import('./products/product.module').then((m) => m.ProductModule) },

  { path: 'warehouse', loadChildren: () => import('./warehouses/warehouse.module').then((m) => m.WarehouseModule) },

  { path: 'partner', loadChildren: () => import('./partners/partner.module').then((m) => m.PartnerModule) },
  { path: 'transaction', loadChildren: () => import('./Transactions/transaction.module').then((m) => m.TransactionModule) },
  { path: 'dashboard', loadChildren: () => import('./Dashboard/dashboard.module').then((m) => m.DashboardModule) },

  { path: 'forbidden', component: ForbiddenComponent },

  { path: '**', component: PageNotFoundComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

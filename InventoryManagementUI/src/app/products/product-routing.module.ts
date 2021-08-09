import { ProductUpdateComponent } from './components/product-update/product-update.component';
import { ProductCreateComponent } from './components/product-create/product-create.component';
import { ProductIndexComponent } from './components/product-index/product-index.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: "", component: ProductIndexComponent },
  { path: "add", component: ProductCreateComponent },
  { path: "edit/:id", component: ProductUpdateComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductRoutingModule { }


import { SharedModule } from './../shared/shared.module';
import { ProductIndexComponent } from './components/product-index/product-index.component';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductRoutingModule } from './product-routing.module';

import { ProductCreateComponent } from './components/product-create/product-create.component';

import { NzTabsModule } from 'ng-zorro-antd/tabs';
import { ProductUpdateComponent } from './components/product-update/product-update.component';
import { ProductForm1Component } from './components/product-form1/product-form1.component';
import { ProductDetailsFormComponent } from './components/product-details-form/product-details-form.component';
import { ProductFormComponent } from './components/product-form/product-form.component';



@NgModule({
  declarations: [
    ProductIndexComponent, ProductCreateComponent, ProductUpdateComponent, ProductFormComponent, ProductForm1Component, ProductDetailsFormComponent
  ],
  imports: [
    CommonModule,
    ProductRoutingModule,
    // DataTablesModule,
    NzTabsModule,
    SharedModule,

  ]

  ,
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA
  ]

})
export class ProductModule { }

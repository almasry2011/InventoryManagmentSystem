import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { WarehouseRoutingModule } from './warehouse-routing.module';
import { WarehouseFormComponent } from './components/warehouse-form/warehouse-form.component';
import { WarehouseIndexComponent } from './components/warehouse-index/warehouse-index.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    WarehouseFormComponent,
    WarehouseIndexComponent
  ],
  imports: [
    CommonModule,
    WarehouseRoutingModule,
    SharedModule
  ]
})
export class WarehouseModule { }

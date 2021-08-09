import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { DashboardIndexComponent } from './components/dashboard-index/dashboard-index.component';
import { DashboardTopCardsComponent } from './components/dashboard-top-cards/dashboard-top-cards.component';

@NgModule({
  declarations: [
    DashboardIndexComponent,
    DashboardTopCardsComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,

  ]
})
export class DashboardModule { }

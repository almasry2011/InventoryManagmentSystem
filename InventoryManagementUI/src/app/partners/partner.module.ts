import { PartnerFormComponent } from './components/partner-form/partner-form.component';
import { PartnerIndexComponent } from './components/partner-index/partner-index.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedModule } from '../shared/shared.module';

import { PartnerRoutingModule } from './partner-routing.module';


@NgModule({
  declarations: [PartnerIndexComponent, PartnerFormComponent],
  imports: [
    CommonModule,
    PartnerRoutingModule,
    SharedModule
  ]
})
export class PartnerModule { }

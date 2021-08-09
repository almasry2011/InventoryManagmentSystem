import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PartnerIndexComponent } from './components/partner-index/partner-index.component';

const routes: Routes = [
  { path: "", component: PartnerIndexComponent },

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PartnerRoutingModule { }

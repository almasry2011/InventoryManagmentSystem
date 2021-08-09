import { AuthService } from './Auth/services/auth.service';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { NgxSpinnerModule } from 'ngx-spinner';
import { CommonModule } from '@angular/common';
import { ToastrModule } from 'ngx-toastr';
import { ForbiddenComponent } from './components/forbidden/forbidden.component';
import { DataTablesModule } from 'angular-datatables';


@NgModule({
  declarations: [
    ForbiddenComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxSpinnerModule,
    ToastrModule.forRoot(),
    DataTablesModule
  ],
  // providers: [AuthService]
})
export class CoreModule { }

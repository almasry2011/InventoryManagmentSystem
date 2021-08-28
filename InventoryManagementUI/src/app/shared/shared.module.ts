import { LazySelectComponent } from './lazy-select/lazy-select.component';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { NzSelectModule } from 'ng-zorro-antd/select';
import { NgxSpinnerModule } from 'ngx-spinner';
import { ToastrModule } from 'ngx-toastr';
import { DatePickerComponent } from '../shared/date-picker/date-picker.component';
import { NzDatePickerModule } from 'ng-zorro-antd/date-picker';
import { NzSpinModule } from 'ng-zorro-antd/spin';
import { NzModalModule } from 'ng-zorro-antd/modal';
import { NzSwitchModule } from 'ng-zorro-antd/switch';
import { DataTablesModule } from 'angular-datatables';
import { FileUploaderComponent } from '../shared/file-uploader/file-uploader.component';

import { NzUploadModule } from 'ng-zorro-antd/upload';
import { NzMessageModule } from 'ng-zorro-antd/message';
import { HttpInterceptorService } from '../core/Interceptor/http-interceptor.service';
import { NzRadioModule } from 'ng-zorro-antd/radio';
import { NzCheckboxModule } from 'ng-zorro-antd/checkbox';
import { ValidationComponent } from './components/validation/validation.component';


@NgModule({
  declarations: [LazySelectComponent, DatePickerComponent, FileUploaderComponent, ValidationComponent],
  imports: [CommonModule, NzSelectModule,
    FormsModule,
    DataTablesModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxSpinnerModule,
    ToastrModule.forRoot(),
    NzSwitchModule,
    NzSpinModule,
    NzModalModule,
    NzSwitchModule,
    NzDatePickerModule,
    NzMessageModule,
    NzUploadModule,
    NzCheckboxModule,
    NzRadioModule

  ],
  exports: [LazySelectComponent, NzRadioModule,ValidationComponent, FileUploaderComponent, DatePickerComponent, DataTablesModule, NzMessageModule, NzDatePickerModule, NzUploadModule, NzSwitchModule, FormsModule, NzSwitchModule, NzModalModule, ReactiveFormsModule, HttpClientModule, NgxSpinnerModule, ToastrModule, NzSpinModule, NzCheckboxModule],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpInterceptorService,
      multi: true,
    }

  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class SharedModule { }

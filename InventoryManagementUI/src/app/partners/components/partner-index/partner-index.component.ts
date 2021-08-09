import { PartnerFormComponent } from './../partner-form/partner-form.component';
import { PartnersService } from './../../services/partners.service';
import { PartnerModel } from './../../models/partner-model';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NzModalService } from 'ng-zorro-antd/modal';
import { BaseComponent } from 'src/app/core/components/base/base.component';

@Component({
  selector: 'app-partner-index',
  templateUrl: './partner-index.component.html',
  styleUrls: ['./partner-index.component.css']
})
export class PartnerIndexComponent extends BaseComponent<PartnerModel> implements OnInit, AfterViewInit {

  constructor(http: HttpClient, private partnerSvc: PartnersService, private modal: NzModalService) {
    super(http);
  }


  ngOnInit(): void {

    this.loadMore();

    //debugger;
    let columns = [
      { data: 'id' },
      { data: 'name' },
      { data: 'phoneNumber' },
      { data: 'email' },
      // { data: 'fullAddress' },
      // { data: null },
      // { data: '' },
    ];



    this.InitDt('Partner/GetDataTablePaggedList', columns);
  }

  ngAfterViewInit(): void {
    this.CallngAfterViewInit();
  }
  Edit(Id: number): void {
    this.partnerSvc.getById(Id).subscribe(data => {
      console.log(data);



      this.modal.create({
        nzTitle: 'Update Partner',
        nzContent: PartnerFormComponent,
        nzMaskClosable: false,
        nzOkText: 'Update',
        nzWidth: '60%',


        nzComponentParams: {
          partner: data.data,
          IsCreateForm: false
        }
      });





    })


  }

  Delete(Id: number) { }
  Add(): void {

    this.modal.create({
      nzTitle: 'Add New',
      nzContent: PartnerFormComponent,
      nzMaskClosable: false,
      nzOkText: 'Create',
      nzWidth: '60%',
      nzComponentParams: {
        IsCreateForm: true
      },
    });


  }


}

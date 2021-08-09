import { WarehouseFormComponent } from './../warehouse-form/warehouse-form.component';
import { WarehouseModel } from './../../models/warehouse-model';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/core/components/base/base.component';
import { HttpClient } from '@angular/common/http';
import { NzModalService } from 'ng-zorro-antd/modal';
import { WarehousesService } from '../../services/warehouses.service';

@Component({
  selector: 'app-warehouse-index',
  templateUrl: './warehouse-index.component.html',
  styleUrls: ['./warehouse-index.component.css']
})
export class WarehouseIndexComponent extends BaseComponent<WarehouseModel> implements OnInit, AfterViewInit {

  constructor(http: HttpClient, private whSvc: WarehousesService, private modal: NzModalService) {
    super(http);
  }


  ngOnInit(): void {

    this.loadMore();

    //debugger;
    let columns = [
      { data: 'id' },
      { data: 'name' },
      // { data: null },
      // { data: null },
      // { data: null },
      // { data: null },
      // { data: '' },
    ];
    this.InitDt('Warehouse/GetDataTablePaggedList', columns);
  }

  ngAfterViewInit(): void {
    this.CallngAfterViewInit();
  }
  Edit(Id: number): void {
    this.whSvc.getById(Id).subscribe(data => {
      console.log(data);



      this.modal.create({
        nzTitle: 'Update WareHouse',
        nzContent: WarehouseFormComponent,
        nzMaskClosable: false,
        nzOkText: 'Update',
        nzWidth: '60%',


        nzComponentParams: {
          warehouse: data.data,
          IsCreateForm: false
        }
      });





    })


  }

  Delete(Id: number) { }
  Add(): void {

    this.modal.create({
      nzTitle: 'Add New',
      nzContent: WarehouseFormComponent,
      nzMaskClosable: false,
      nzOkText: 'Create',
      nzWidth: '60%',
      nzComponentParams: {
        IsCreateForm: true
      },
    });


  }




}

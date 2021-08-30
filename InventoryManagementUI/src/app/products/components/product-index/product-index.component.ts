import { HttpClient } from '@angular/common/http';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';
import { BaseComponent } from 'src/app/core/components/base/base.component';
import { ProductModel } from '../../models/product-model';
import { ProductsService } from '../../services/products.service';

@Component({
  selector: 'app-product-index',
  templateUrl: './product-index.component.html',
  styleUrls: ['./product-index.component.css']
})
export class ProductIndexComponent extends BaseComponent<ProductModel> implements OnInit, AfterViewInit {


  constructor(private productsSvc: ProductsService, http: HttpClient, private modal: NzModalService, private toasterSvc: ToastrService) {
    super(http);
  }



  ngOnInit(): void {

    this.loadMore();

     debugger;
    let columns = [
      { data: 'id' },
      { data: 'name' },
      { data: 'sellingUnitPrice' },
      { data: 'numberInStock' },
      { data: 'productCategoryId' },
      { data: 'warehouseId' },
      { data: 'warehouseBinId' },

    ];
    this.InitDt('product/GetDataTablePaggedList', columns);
  }

  ngAfterViewInit(): void {
    this.CallngAfterViewInit();
  }
  Edit(Id: number): void { }

  Delete(Id: number) {
    debugger;


    this.modal.confirm({
      nzTitle: 'Are you sure delete this Item?',
      nzContent: '<b style="color: red;">Some descriptions</b>',
      nzOkText: 'Yes',
      nzOkType: 'primary',
      nzOkDanger: true,
      nzOnOk: () => {
        console.log('OK');
        this.productsSvc.DeleteProduct(Id).subscribe(res => {
          if (res) {
            this.toasterSvc.success('Successfully Deleted');
            this.rerender();
          }
        })

      },
      nzCancelText: 'No',
      nzOnCancel: () => { console.log('Cancel'); }
    });


  }






  Add(): void { }

  OndateChange(event: any) {
    console.log(event)
  }




}

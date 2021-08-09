import { TransactionsService } from './../../services/transactions.service';
import { TransactionModel } from './../../models/transaction-model';
import { AfterViewInit, Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseComponent } from 'src/app/core/components/base/base.component';
import { ProductsService } from 'src/app/products/services/products.service';

@Component({
  selector: 'app-transaction-index',
  templateUrl: './transaction-index.component.html',
  styleUrls: ['./transaction-index.component.css']
})
export class TransactionIndexComponent extends BaseComponent<TransactionModel> implements OnInit, AfterViewInit {


  constructor(private TrxSvc: TransactionsService, http: HttpClient) {
    super(http);
  }


  ngOnInit(): void {

    this.loadMore();

    //debugger;
    let columns = [
      { data: 'id' },
      { data: '' },
      { data: 'transactionType' },
      { data: '' },
    ];
    this.InitDt('Transaction/GetDataTablePaggedList', columns);
  }

  ngAfterViewInit(): void {
    this.CallngAfterViewInit();
  }
  Edit(Id: number): void { }

  Delete(Id: number) { }

  Add(): void { }




  OndateChange(event: any) {
    console.log(event)
  }

}

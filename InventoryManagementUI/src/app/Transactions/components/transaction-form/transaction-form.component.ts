import { ProductDetail } from 'src/app/products/models/ProductDetail';
import { ProductModel } from './../../../products/models/product-model';
import { TransactionModel, TransactionLine } from './../../models/transaction-model';
import { TransactionsService } from './../../services/transactions.service';
import { Component, Input, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';
import { FormUtils } from 'src/app/core/FormUtils';

@Component({
  selector: 'app-transaction-form',
  templateUrl: './transaction-form.component.html',
  styleUrls: ['./transaction-form.component.css']
})
export class TransactionFormComponent implements OnInit {
  @Input() IsCreateForm: boolean = true;
  @Input() IsSaleTrx: boolean = true;

  totalPrice: number = 0;
  transaction!: TransactionModel;
  SelectedProduct!: ProductModel;
  BoxChecked: boolean = false;
  BoxNum: number = 0;
  multpleMode: boolean = false;
  title: string = this.IsSaleTrx ? "New Sale Transaction" : "New Procurement Transaction"

  MainForm!: FormGroup;

  id!: FormControl;
  partnerId!: FormControl;
  transactionDate!: FormControl;
  transactionType!: FormControl;
  quantity!: FormControl;

  _TransactionLines!: any;
  saleTrxLines: TransactionLine[] = [];



  constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private TrxSvc: TransactionsService, private modal: NzModalService, private toasterSvc: ToastrService) { }

  partnerInitVal: any = null;
  partnerPlaceHolder = 'Please Select Partener';
  partnerDisabled: boolean = false;
  MultiMode: boolean = false;
  pageSize: number = 10;
  partnerURl: string = '/partner/GetAllFiltered'

  partnerChanged(event: any) {
    console.log(event);
    this.partnerDisabled = true;
    FormUtils.SetFormControleValue(this.partnerId, event.id);
  }


  prodInitVal: any = null;
  prodPlaceHolder = 'Please Select Product';
  prodDisabled: boolean = false;
  prodURl: string = '/product/GetAllFiltered'
  prodChanged(event: any) {
    console.log(event);
    debugger;

    // var IsExsist = this._TransactionLines
    //   .filter((s: any) => s.productId == event.id);

    // if (IsExsist.length > 0) {
    //   this.toasterSvc.warning('Product already in your order')
    //   return;
    //}



    this.SelectedProduct = event;

  }





  ngOnInit() {
    this.initForm()
    const id = this.route.snapshot.paramMap?.get('id');
    if (id != null) {
      let trxId = + id;

      this.TrxSvc.getById(trxId).subscribe(trx => {
        if (trx.success) {
          this.transaction = trx.data;

          this.partnerInitVal = { name: trx.data.partnerName };
          // this.catInitVal = { name: prod.data.productCategoryStr };
          // this.binInitVal = { name: prod.data.warehouseBinStr };

          // prod.data.boxNumber > 0 ? this.BoxChangeEvent(true) : this.BoxChangeEvent(false);
          // this.BoxCheked = prod.data.boxNumber > 0 ? true : false;

          this.initForm(this.transaction)
        }
      })
    } else {

      this.onValueChanges()
    }





  }

  initForm(model?: TransactionModel) {
    this.id = new FormControl((model != null && !this.IsCreateForm) ? model.id : 0);
    this.partnerId = new FormControl((model != null && !this.IsCreateForm) ? model.partnerId : '', Validators.compose([Validators.required, Validators.min(1)]));
    this.transactionType = new FormControl(this.IsSaleTrx ? 0 : 1, Validators.compose([Validators.required, Validators.minLength(1), Validators.maxLength(200)]));


    this.quantity = new FormControl(0);

    this.transactionDate = new FormControl((model != null && !this.IsCreateForm) ? model.transactionDate : 0, Validators.compose([Validators.required]));
    this._TransactionLines = new FormControl();


    this.MainForm = this.fb.group({
      id: this.id,
      partnerId: this.partnerId,
      transactionType: this.transactionType,
      transactionDate: this.transactionDate,
      quantity: this.quantity,
      _TransactionLines: this._TransactionLines,
      // _TransactionLines: this._TransactionLines


    });


  }








  AddTrxDetails(event: any) {
    debugger
    this.prodInitVal = {};
    this._TransactionLines.setValue(event)
    this.totalPrice = event.length > 0 ? event.map((s: any) => s.buyingPrice).reduce((prev: any, next: any) => prev + next) : 0;
  }


  OnFormSubmit() {

    console.log(this.MainForm);
    if (this.MainForm.valid) {
      const model = this.MainForm.getRawValue();
      console.log(model)
      if (this.IsSaleTrx) {
        this._TransactionLines.setValue(this.saleTrxLines);
        model._TransactionLines = this.saleTrxLines;
        console.log(this.MainForm.getRawValue());
        this.TrxSvc.SaleTransaction(model).subscribe(res => {
          console.log(res)
          if (res) {

            this.toasterSvc.success('Transaction Created Successfully');
            if (!this.multpleMode) {

              this.router.navigate(['transaction'])
            }


          }
        })
      } else {
        this.TrxSvc.PurchaseTransaction(model).subscribe(res => {
          console.log(res)
          if (res) {

            this.toasterSvc.success('Transaction Created Successfully');
            this.router.navigate(['transaction'])
          }
        })

      }
    }
  }


  AddSaleRow() {
    debugger
    this.MainForm.markAsTouched()
    console.log(this.MainForm);
    if (this.MainForm.valid && this.SelectedProduct && this.quantity.value > 0) {
      const model = this.MainForm.getRawValue();
      console.log(model)
      let line: TransactionLine = {
        product: this.SelectedProduct,
        productId: this.SelectedProduct.id,
        productName: this.SelectedProduct.name,
        quantity: this.quantity.value,
        box: this.BoxChecked,
        sellingUnitPrice: this.SelectedProduct?.sellingUnitPrice,
        sellingBoxPrice: this.SelectedProduct?.sellingBoxPrice,
        profit: 5,
        total: this.quantity.value * (this.SelectedProduct?.sellingUnitPrice || 0),
      }

      this.saleTrxLines.push(line);
      this.SelectedProduct = {};
      this.prodInitVal = {};
      this.quantity.setValue(0);
      this.quantity.reset();
      this.BoxChecked = false;
      this.transactionDate.disable();

      this.BoxChecked = false;
      this.quantity.enable();
      this.BoxNum = 0;
    } else {
      this.toasterSvc.error('error')
    }

  }

  BoxCheckedFun(e: any) {
    console.log(e.target.checked)
    if (e.target.checked && this.SelectedProduct) {
      this.BoxNum = 1;
      this.BoxChecked = true;
      this.quantity.disable();
      this.quantity.setValue((this.SelectedProduct?.itemsInBox || 0) * this.BoxNum)
    } else {
      this.BoxChecked = false;
      this.BoxNum = 0;
      this.quantity.enable();

    }

  }

  BoxNumChange() {
    if (this.BoxNum > 0) {
      this.quantity.setValue((this.SelectedProduct?.itemsInBox || 0) * this.BoxNum)
    } else {
      this.BoxChecked = false;
      this.quantity.enable();
      this.BoxNum = 0;

    }

  }


  onValueChanges(): void {
    //debugger;

    this.transactionDate.valueChanges.subscribe(val => {
      // this.transactionDate.disable();


    });


    // this.buyingPrice.valueChanges.subscribe(val => {
    //   // this.MainForm.controls['StockPriceInfo'].get('buyingPrice')?.valueChanges.subscribe(val => {
    //   this.sellingPrice.setValue(val)
    //   this.sellingPrice.setValidators(Validators.min(val));
    //   this.sellingPrice.markAsTouched();
    //   console.log(`My name is ${val}.`);
    // });

    // this.productionDate.valueChanges.subscribe(val => {
    //   //this.MainForm.controls['StockPriceInfo'].get('productionDate')?.valueChanges.subscribe(val => {
    //   this.disabledDate = (current: Date): boolean => {
    //     return differenceInCalendarDays(val, current) + 30 > 0;
    //   };
    // });


  }


  EditRow(row: TransactionLine) {
    debugger;
    this.saleTrxLines

    //this.SubmitBtnValue = "Update";
    //this.UpdateFormMode = true;
    //this.CurrenUpdatedItem = row;
    //  this.Product = row;
    this.MainForm.reset(row);
    this.MainForm.markAllAsTouched();
  }
  DeletRow(row: TransactionLine) {

    debugger;
    let indexOfCurrent = this.saleTrxLines.indexOf(row)
    this.modal.confirm({
      nzTitle: 'Are you sure delete this Item?',
      nzContent: '<b style="color: red;">Some descriptions</b>',
      nzOkText: 'Yes',
      nzOkType: 'primary',
      nzOkDanger: true,
      nzOnOk: () => {
        console.log('OK');
        if (indexOfCurrent >= 0) {
          this.saleTrxLines.splice(indexOfCurrent, 1);
        }
      },
      nzCancelText: 'No',
      nzOnCancel: () => { console.log('Cancel'); }
    });


  }






}

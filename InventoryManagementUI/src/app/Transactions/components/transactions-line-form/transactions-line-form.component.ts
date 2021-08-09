import { ProductModel } from 'src/app/products/models/product-model';

import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { NzModalRef, NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';

import { differenceInCalendarDays } from 'date-fns';
import { ProductDetail } from 'src/app/products/models/ProductDetail';

@Component({
  selector: 'app-transactions-line-form',
  templateUrl: './transactions-line-form.component.html',
  styleUrls: ['./transactions-line-form.component.css']
})
export class TransactionlineFormFormComponent implements OnInit {
  // @Input() itemsInBox: number = 0;
  @Input() Product: ProductModel = {};
  @Output() EmitLine = new EventEmitter<any>();

  disabledDate: any;
  UpdateFormMode: boolean = false;

  CurrenUpdatedItem: any = null;
  SubmitBtnValue = "Add";
  CalculatedUnitPrice: number = 0;
  CalculatedProfit: number = 0;

  WholesaleProfit: number = 0;
  WholesaleBoxProfit: number = 0;
  SegmentalProfit: number = 0;

  WholesaleUnitPrice: number = 0;
  SegmentalUnitPrice: number = 0;

  Stock: number = 0;

  trxLines: ProductDetail[] = [];


  MainForm!: FormGroup;
  productId!: FormControl;
  id!: FormControl;

  trxLinesId!: FormControl;
  buyingPrice!: FormControl;
  descriptiondtls!: FormControl;
  boxNumbers!: FormControl;
  boxPrice!: FormControl;
  productionDate!: FormControl;
  expiryDate!: FormControl;


  constructor(private fb: FormBuilder, private modal: NzModalService) { }

  ngOnInit(): void {
    debugger
    this.initForm()
    this.onChanges();
  }
  onChanges(): void {
    this.MainForm.valueChanges.subscribe(val => {



      // debugger;

      this.productionDate.valueChanges.subscribe(val => {
        //this.MainForm.controls['StockPriceInfo'].get('productionDate')?.valueChanges.subscribe(val => {
        this.disabledDate = (current: Date): boolean => {
          return differenceInCalendarDays(val, current) + 30 > 0;
        };
      });




      this.buyingPrice.valueChanges.subscribe(val => {
        this.AdjustPriceStockProfit();
      });

      // this.boxPrice.valueChanges.subscribe(val => {
      //   this.AdjustPriceStockProfit();

      //   if (!this.UpdateFormMode) {

      //     this.buyingPrice.setValue(val * this.boxNumbers.value)
      //   }

      // });


      // this.unitPrice.valueChanges.subscribe(val => {
      //   this.AdjustPriceStockProfit();
      // });



    });
  }



  AdjustPriceStockProfit() {
    // debugger;

    this.boxPrice.setValue(this.buyingPrice.value / this.boxNumbers.value)
    this.CalculatedUnitPrice = this.boxPrice.value / (this.Product.itemsInBox || 0);

    this.WholesaleBoxProfit =
      (this.Product.sellingBoxPrice || 0) - (this.boxPrice.value);


    //    * this.boxNumber.value)
    // -
    // (this.boxPrice.value * this.boxNumber.value)

    this.WholesaleProfit = ((this.Product.sellingBoxPrice || 0) * this.boxNumbers.value) - this.buyingPrice.value;



    this.SegmentalProfit =

      (((this.Product.itemsInBox || 0) * this.boxNumbers.value) * (this.Product.sellingUnitPrice || 0) -
        (this.boxPrice.value * this.boxNumbers.value));

    this.Stock = ((this.Product.itemsInBox || 0) * this.boxNumbers.value)

  }





  initForm() {
    debugger
    this.trxLinesId = new FormControl(0);
    this.productId = new FormControl(0);


    this.buyingPrice = new FormControl(0, Validators.compose([Validators.required, Validators.min(1)]));

    this.productionDate = new FormControl(null, Validators.compose([Validators.required]));
    this.expiryDate = new FormControl(null, Validators.compose([Validators.required]));



    this.descriptiondtls = new FormControl('');

    this.boxNumbers = new FormControl(0, Validators.compose([Validators.required, Validators.min(1)]));
    this.boxPrice = new FormControl(0, Validators.compose([Validators.required, Validators.min(1)]));


    this.MainForm = this.fb.group({
      trxLinesId: this.trxLinesId,
      productId: this.productId,

      buyingPrice: this.buyingPrice,
      productionDate: this.productionDate,
      expiryDate: this.expiryDate,

      boxNumbers: this.boxNumbers,
      boxPrice: this.boxPrice
    });
  }







  OnFormSubmit() {
    this.MainForm.markAllAsTouched();
    console.log(this.MainForm);
    debugger;
    if (this.MainForm.valid) {
      const model = this.MainForm.getRawValue()
      model.productName = this.Product.name;
      model.productId = this.Product.id;

      model.itemsInBox = this.Product.itemsInBox;
      model.sellingBoxPrice = this.Product.sellingBoxPrice;
      model.sellingUnitPrice = this.Product.sellingUnitPrice;







      model.wholesaleBoxProfit = this.WholesaleBoxProfit;



      model.wholesaleUnitPrice = this.boxPrice.value / (this.Product.itemsInBox || 0);
      model.segmentalUnitPrice = this.Product.sellingUnitPrice;
      model.calculatedUnitPrice = this.CalculatedUnitPrice;
      model.wholesaleProfit = this.WholesaleProfit;
      model.segmentalProfit = this.SegmentalProfit;
      model.stock = this.Stock;

      if (this.UpdateFormMode) {
        // model.productName = this.CurrenUpdatedItem.Product.name;
        // model.productId = this.CurrenUpdatedItem.Product.id;
        // model.itemsInBox = this.CurrenUpdatedItem.itemsInBox;
        // model.sellingBoxPrice = this.CurrenUpdatedItem.sellingBoxPrice;
        // model.sellingUnitPrice = this.CurrenUpdatedItem.sellingUnitPrice;

        debugger
        let currentIndex = this.trxLines.indexOf(this.CurrenUpdatedItem)
        model.Product = this.Product;
        let x = this.trxLines[currentIndex];
        let y = x.Product;
        this.trxLines[currentIndex] = model

      } else {
        model.productCode = `#${Math.floor((Math.random() * 100000) + 1)}`;
        model.Product = this.Product;
        this.trxLines.push(model);
      }

      console.log(model)
      this.MainForm.reset();
      this.SubmitBtnValue = "Add";
      this.UpdateFormMode = false;

      this.Product = {};

      this.EmitLine.next(this.trxLines);
    }
  }



  // let currentIndex = this.trxLines.findIndex(x => x.trxLinesId === result.trxLinesId && x.productCode === result.productCode)

  // if (currentIndex >= 0) {
  //   this.trxLines[currentIndex] = result
  // } else {
  //   this.trxLines.push(result)
  // }


  EditRow(row: any) {
    debugger;
    this.trxLines
    this.Product = row.Product
    this.SubmitBtnValue = "Update";
    this.UpdateFormMode = true;
    this.CurrenUpdatedItem = row;
    //  this.Product = row;
    this.MainForm.reset(row);
    this.MainForm.markAllAsTouched();
  }

  DeletRow(row: any) {
    debugger;
    let indexOfCurrent = this.trxLines.indexOf(row)
    this.modal.confirm({
      nzTitle: 'Are you sure delete this Item?',
      nzContent: '<b style="color: red;">Some descriptions</b>',
      nzOkText: 'Yes',
      nzOkType: 'primary',
      nzOkDanger: true,
      nzOnOk: () => {
        console.log('OK');
        if (indexOfCurrent >= 0) {
          if (row.id > 0) {
            this.trxLines[indexOfCurrent].rowStatus = 'delete';
          } else {
            this.trxLines.splice(indexOfCurrent, 1);
          }
          this.EmitLine.next(this.trxLines);
        }
      },
      nzCancelText: 'No',
      nzOnCancel: () => { console.log('Cancel'); }
    });


  }





}

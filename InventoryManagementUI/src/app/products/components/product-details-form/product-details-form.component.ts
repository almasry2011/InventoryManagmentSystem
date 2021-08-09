import { data } from 'jquery';
import { ProductDetail } from './../../models/ProductDetail';
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { NzModalRef, NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';
import { ProductsService } from '../../services/products.service';
import { differenceInCalendarDays } from 'date-fns';

@Component({
  selector: 'app-product-details-form',
  templateUrl: './product-details-form.component.html',
  styleUrls: ['./product-details-form.component.css']
})
export class ProductDetailsFormComponent implements OnInit {
  @Input() IsCreateForm: boolean = true;
  @Input() DetailsModel!: ProductDetail;
  disabledDate: any;
  CalculatedUnitPrice: number = 0;
  CalculatedProfit: number = 0;
  //BoxCheked: boolean = false;
  WholesaleProfit: number = 0;
  SegmentalProfit: number = 0;

  WholesaleUnitPrice: number = 0;
  SegmentalUnitPrice: number = 0;

  Stock: number = 0;


  MainForm!: FormGroup;
  productId!: FormControl;
  id!: FormControl;

  productDetailsId!: FormControl;
  sellingPrice!: FormControl;
  buyingPrice!: FormControl;
  unitPrice!: FormControl;
  descriptiondtls!: FormControl;
  boxNumber!: FormControl;
  itemsInBox!: FormControl;
  boxPrice!: FormControl;
  productionDate!: FormControl;
  expiryDate!: FormControl;
  productCode!: FormControl;

  StockPriceInfo!: FormGroup;
  BoxInfo!: FormGroup;
  constructor(private fb: FormBuilder, private prodSvc: ProductsService, private modal: NzModalService, private toasterSvc: ToastrService, private modalRef: NzModalRef) { }

  ngOnInit(): void {
    this.initForm()
    this.onChanges();
  }
  onChanges(): void {
    this.MainForm.valueChanges.subscribe(val => {

      //  console.log(val)


      // this.buyingPrice.valueChanges.subscribe(val => {
      //   this.productCode.setValue(`#${Math.floor((Math.random() * 100000) + 1)}`)
      //   this.sellingPrice.setValue(val)
      //   this.sellingPrice.markAsTouched();
      //   this.productCode.markAsTouched();
      // });



      debugger;

      this.productionDate.valueChanges.subscribe(val => {
        //this.MainForm.controls['StockPriceInfo'].get('productionDate')?.valueChanges.subscribe(val => {
        this.disabledDate = (current: Date): boolean => {
          return differenceInCalendarDays(val, current) + 30 > 0;
        };
      });


      this.itemsInBox.valueChanges.subscribe(val => {
        this.AdjustPriceStockProfit();
        // this.CalculateStock();

      });

      this.buyingPrice.valueChanges.subscribe(val => {
        this.AdjustPriceStockProfit();
      });

      this.boxPrice.valueChanges.subscribe(val => {
        this.AdjustPriceStockProfit();

        this.buyingPrice.setValue(val * this.boxNumber.value)


        this.sellingPrice.setValue(val)
        this.sellingPrice.markAsTouched();
        this.productCode.markAsTouched();


      });


      this.unitPrice.valueChanges.subscribe(val => {
        this.AdjustPriceStockProfit();
      });



    });
  }



  AdjustPriceStockProfit() {
    debugger;



    this.CalculatedUnitPrice = this.boxPrice.value / this.itemsInBox.value;

    this.WholesaleProfit =
      (this.sellingPrice.value * this.boxNumber.value)
      -
      (this.boxPrice.value * this.boxNumber.value)
      ;

    this.SegmentalProfit =

      ((this.itemsInBox.value * this.boxNumber.value) * this.unitPrice.value) -
      (this.boxPrice.value * this.boxNumber.value)
      ;

    this.Stock = (this.itemsInBox.value * this.boxNumber.value)

  }





  initForm() {
    debugger
    // this.id = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.id : 0);
    this.productDetailsId = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.productDetailsId : 0);

    //let sellingPriceVal = (this.DetailsModel && !this.IsCreateForm) ? this.DetailsModel.sellingPrice : 0;

    this.productId = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.productId : 0);

    this.productCode = new FormControl({ value: (this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.productCode : `#${Math.floor((Math.random() * 100000) + 1)}`, disabled: true }, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)]));


    this.sellingPrice = new FormControl((this.DetailsModel && !this.IsCreateForm) ? this.DetailsModel.sellingPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));

    this.buyingPrice = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.buyingPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.unitPrice = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.unitPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));

    this.productionDate = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.productionDate : null, Validators.compose([Validators.required]));
    this.expiryDate = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.expiryDate : null, Validators.compose([Validators.required]));



    this.descriptiondtls = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.description : '');
    // this.boxNumber = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.boxNumber : 0, Validators.compose([Validators.required, Validators.min(1)]));
    // this.itemsInBox = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.itemsInBox : 0, Validators.compose([Validators.required, Validators.min(1)]));
    // this.boxPrice = new FormControl((this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.boxPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));

    this.boxNumber = new FormControl({ value: (this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.boxNumber : 0, disabled: false }, Validators.compose([Validators.required, Validators.min(1)]));
    this.itemsInBox = new FormControl({ value: (this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.itemsInBox : 0, disabled: false }, Validators.compose([Validators.required, Validators.min(1)]));
    this.boxPrice = new FormControl({ value: (this.DetailsModel != null && !this.IsCreateForm) ? this.DetailsModel.boxPrice : 0, disabled: false }, Validators.compose([Validators.required, Validators.min(1)]));




    this.StockPriceInfo = this.fb.group({
      productDetailsId: this.productDetailsId,
      productId: this.productId,
      sellingPrice: this.sellingPrice,
      buyingPrice: this.buyingPrice,
      productionDate: this.productionDate,
      expiryDate: this.expiryDate,
      unitPrice: this.unitPrice,
      productCode: this.productCode,
    });

    this.BoxInfo = this.fb.group({
      boxNumber: this.boxNumber,
      itemsInBox: this.itemsInBox,
      boxPrice: this.boxPrice

    });

    this.MainForm = this.fb.group({
      StockPriceInfo: this.StockPriceInfo,
      BoxInfo: this.BoxInfo,
    });
  }







  OnFormSubmit() {
    console.log(this.MainForm);
    debugger;
    if (this.MainForm.valid) {
      const model = { ...this.MainForm.getRawValue().StockPriceInfo, ...this.MainForm.getRawValue().BoxInfo }

      model.wholesaleUnitPrice = this.boxPrice.value / this.itemsInBox.value;
      model.segmentalUnitPrice = this.unitPrice.value
      model.calculatedUnitPrice = this.CalculatedUnitPrice;
      model.wholesaleProfit = this.WholesaleProfit;
      model.segmentalProfit = this.SegmentalProfit;
      model.stock = this.Stock;

      console.log(model)
      this.modalRef.close(model);

    }
  }
}

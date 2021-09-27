
import { ProductDetailsFormComponent } from './../product-details-form/product-details-form.component';
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators, FormArray } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';
import { FormUtils } from 'src/app/core/FormUtils';
import { ProductModel } from '../../models/product-model';
import { ProductDetail } from '../../models/ProductDetail';
import { ProductsService } from '../../services/products.service';
import { CustomValidation } from 'src/app/shared/validators/CustomValidation';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
  @Input() IsCreateForm: boolean = true;

 

  


  BoxCheked: boolean = false;
  multpleMode: boolean = false;
  CalculatedUnitPrice: number = 0;
  CalculatedProfit: number = 0;
  ProductDetails: ProductDetail[] = [];
  public selectedIndex = 0;
  disabledDate: any;



  title: string = this.IsCreateForm ? "Craete Product" : "Edit Product"

  MainForm!: FormGroup;

  id!: FormControl;
  name!: FormControl;
  description!: FormControl;

  numberInStock!: FormControl;
  productCode!: FormControl;
  productCategoryId!: FormControl;
  warehouseId!: FormControl;
  warehouseBinId!: FormControl;
  sellingUnitPrice!: FormControl;
  sellingBoxPrice!: FormControl;
  // _productDetails!: FormArray;

  //_productDetails?: ProductDetail[];
  productCategoryStr?: string;
  warehouseStr?: string;
  warehouseBinStr?: string;
  itemsInBox!: FormControl;

  //
  // productId!: FormControl;
  // productDetailsId!: FormControl;
  // sellingPrice!: FormControl;
  // buyingPrice!: FormControl;
  // unitPrice!: FormControl;
  // descriptiondtls!: FormControl;
  // boxNumber!: FormControl;
  //
  // boxPrice!: FormControl;
  // productionDate!: FormControl;
  // expiryDate!: FormControl;












  BasicInfo!: FormGroup;
  StockPriceInfo!: FormGroup;
  BoxInfo!: FormGroup;
  // product: ProductModel = {};



  // id?: number;
  // name?: string;
  // productCode?: string;
  // description?: string;
  // numberInStock?: number;
  // productCategoryId?: number;
  // warehouseId?: number;
  // warehouseBinId?: number;




  constructor(private fb: FormBuilder, private route: ActivatedRoute, private router: Router, private prodSvc: ProductsService, private modal: NzModalService, private toasterSvc: ToastrService) { }

  ngOnInit(): void {
    debugger
    const id = this.route.snapshot.paramMap?.get('id');
    if (id != null) {
      let prodId = + id;

      this.prodSvc.getProduct(prodId).subscribe(prod => {
        if (prod.success) {
          // this.product = prod.data;

         // this.whInitVal = { name: prod.data.warehouseStr };
        //  this.catInitVal = { name: prod.data.productCategoryStr };
        //  this.binInitVal = { name: prod.data.warehouseBinStr };

          // prod.data.boxNumber > 0 ? this.BoxChangeEvent(true) : this.BoxChangeEvent(false);
          // this.BoxCheked = prod.data.boxNumber > 0 ? true : false;

          // if (prod.data._productDetails) {
          //   this.ProductDetails = prod.data._productDetails;
          // }


          this.initForm(prod.data)
        }
      })
    }


    this.initForm()
  }


  //#Fourm Lookups
  //whInitVal: any = null;
  //whPlaceHolder = 'Please Select Warehouse';
  //whDisabled: boolean = false;
  //MultiMode: boolean = false;
  pageSize: number = 10;
  whURl: string = '/Warehouse/GetAllFiltered'

  // whChanged(event: any) {
  //   console.log(event);
  //   FormUtils.SetFormControleValue(this.warehouseId, event.id);
  //   this.binfilter = event.id;
  // }

  //
  //catInitVal: any = null;

  //catPlaceHolder = 'Please Select Category';
  //catDisabled: boolean = false;
  catURl: string = '/GetFilteredCategories'
  // catChanged(event: any) {
  //   console.log(event);
  //   FormUtils.SetFormControleValue(this.productCategoryId, event.id);
  //   //this.productCategoryId.setValue(event.id);
  //   //this.BasicInfo.controls['productCategoryId'].setValue(event.id);
  // }

  //
 // binInitVal: any = null;
  //binPlaceHolder = 'Please Select Bin';
  //binDisabled: boolean = false;
  binURl: string = '/GetFilteredWarehouseBins'
  //binfilter = 0;

  //this.warehouseId?.value ? this.warehouseId.value : 0;
  // binChanged(event: any) {
  //   console.log(event);
  //   FormUtils.SetFormControleValue(this.warehouseBinId, event.id);
  // }



  initForm(model?: ProductModel) {
    this.id = new FormControl((model != null && !this.IsCreateForm) ? model.id : 0);
    this.name = new FormControl((model != null && !this.IsCreateForm) ? model.name : '', Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(50) ,CustomValidation.ArabicOnly   ]));
    this.description = new FormControl((model != null && !this.IsCreateForm) ? model.description : '', Validators.compose([Validators.required, Validators.minLength(4), Validators.maxLength(200)]));


    this.numberInStock = new FormControl((model != null && !this.IsCreateForm) ? model.numberInStock : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.productCode = new FormControl((model != null && !this.IsCreateForm) ? model.productCode : '');
    this.productCategoryId = new FormControl((model != null && !this.IsCreateForm) ? model.productCategoryId : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.warehouseId = new FormControl((model != null && !this.IsCreateForm) ? model.warehouseId : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.warehouseBinId = new FormControl((model != null && !this.IsCreateForm) ? model.warehouseBinId : 0, Validators.compose([Validators.required, Validators.min(1)]));

    this.itemsInBox = new FormControl((model != null && !this.IsCreateForm) ? model.itemsInBox : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.sellingUnitPrice = new FormControl((model != null && !this.IsCreateForm) ? model.sellingUnitPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));
    this.sellingBoxPrice = new FormControl((model != null && !this.IsCreateForm) ? model.sellingBoxPrice : 0, Validators.compose([Validators.required, Validators.min(1)]));

    this.BasicInfo = this.fb.group({
      id: this.id,
      name: this.name,
      description: this.description,
      productCategoryId: this.productCategoryId,
      warehouseId: this.warehouseId,
      warehouseBinId: this.warehouseBinId,
      itemsInBox: this.itemsInBox,
      sellingBoxPrice: this.sellingBoxPrice,
      sellingUnitPrice: this.sellingUnitPrice,
      _productDetails: this.ProductDetails

    });

    // this.StockPriceInfo = this.fb.group({
    //   sellingPrice: this.sellingPrice,
    //   buyingPrice: this.buyingPrice,
    //   numberInStock: this.numberInStock,
    //   productCode: this.productCode,
    //   productionDate: this.productionDate,
    //   expiryDate: this.expiryDate,
    //   unitPrice: this.unitPrice
    // });

    // this.BoxInfo = this.fb.group({
    //   boxNumber: this.boxNumber,
    //   itemsInBox: this.itemsInBox,
    //   boxPrice: this.boxPrice

    // });

    this.MainForm = this.fb.group({
      BasicInfo: this.BasicInfo,
    //  productCategoryId: this.productCategoryId,
      //  StockPriceInfo: this.StockPriceInfo,
      //  BoxInfo: this.BoxInfo,
    });
  }



  OnFormSubmit() {
    this.BasicInfo.controls['_productDetails'].setValue(this.ProductDetails);
    console.log(this.MainForm);
    if (this.MainForm.valid) {
      const model = { ...this.MainForm.getRawValue().BasicInfo, ...this.MainForm.getRawValue().StockPriceInfo, ...this.MainForm.getRawValue().BoxInfo }
      console.log(model)


      if (this.IsCreateForm) {
        this.prodSvc.CreateProduct(model).subscribe(res => {
          console.log(res)
          if (res) {

            this.toasterSvc.success('Successfully Created');
            if (!this.multpleMode) {

              this.router.navigate(['product'])
            }


          }
        })
      } else {
        this.prodSvc.UpdateProduct(model).subscribe(res => {
          console.log(res)
          if (res) {

            this.toasterSvc.success('Successfully Updated');
            this.router.navigate(['product'])
          }
        })

      }
    }
  }



  beforeActivateTab(index: number, event: Event) {
    //  debugger;
    $('nz-select').addClass('ng-touched');

    if (index === 1) {
      this.BasicInfo.markAllAsTouched();
      if (this.BasicInfo.valid) {
        this.selectedIndex = index;
      } else {
        this.toasterSvc.error('Please Fill Required Data')
        return;
      }
    }

    // if (index === 2) {
    //   this.StockPriceInfo.markAllAsTouched();
    //   if (this.StockPriceInfo.valid) {
    //     this.selectedIndex = index;
    //   } else {
    //     this.toasterSvc.error('Please Fill Required Data')
    //     return;

    //   }
    // }


    this.selectedIndex = index;







    // event.preventDefault();
    // event.stopPropagation();

    // this.modal.confirm({
    //   nzTitle: `Confirm to leave without saving?`,
    //   nzContent: `OK to go ahead, Cancel to stay current page.`,
    //   nzOnOk: () => new Promise((resolve, reject) => {
    //     this.selectedIndex = index;
    //     resolve();
    //   })
    // });
  }

  addDetails() {
    this.openDetailsModel('Add New');
    // const modal = this.modal.create({
    //   nzTitle: 'Add New',
    //   nzContent: ProductDetailsFormComponent,
    //   nzMaskClosable: false,
    //   nzOkText: 'Add',
    //   nzWidth: '60%',
    //   nzComponentParams: {
    //     // IsCreateForm: true
    //   },

    // });

    // // this.modal.afterOpen.subscribe(() => console.log('[afterOpen] emitted!'));
    // // Return a result when closed
    // modal.afterClose.subscribe(result => {
    //   console.log('[afterClose] The result is:', result)
    //   this.ProductDetails.push(result)
    // });

  }


  openDetailsModel(title: string, model?: ProductDetail) {

    const modal = this.modal.create({
      nzTitle: title,
      nzContent: ProductDetailsFormComponent,
      nzMaskClosable: false,
      // nzOkText: 'Add',
      nzWidth: '60%',
      nzComponentParams: {
        IsCreateForm: model ? false : true,
        DetailsModel: model
      },

    });

    // this.modal.afterOpen.subscribe(() => console.log('[afterOpen] emitted!'));
    // Return a result when closed

    modal.afterClose.subscribe(result => {
      debugger
      console.log('[afterClose] The result is:', result)
      result.rowStatus = model ? 'Update' : 'Create';

      let currentIndex = this.ProductDetails.findIndex(x => x.productDetailsId === result.productDetailsId && x.productCode === result.productCode)

      if (currentIndex >= 0) {
        this.ProductDetails[currentIndex] = result
      } else {
        this.ProductDetails.push(result)
      }

    });

  }

  showDeleteConfirm(message: string): boolean {
    let returnVal: boolean = false;
    this.modal.confirm({
      nzTitle: message,
      nzContent: '<b style="color: red;">Some descriptions</b>',
      nzOkText: 'Yes',
      nzOkType: 'primary',
      nzOkDanger: true,
      nzOnOk: () => {
        console.log('OK');
        returnVal = true;
        // return true;
      },
      nzCancelText: 'No',
      nzOnCancel: () => { console.log('Cancel'); }
    });

    return returnVal;
  }


  EditRow(row: any) {
    this.openDetailsModel('Edit', row)
  }
  DeletRow(row: any) {
    debugger;
    // let index = this.ProductDetails.findIndex(x => x.id === row.id && x.productCode === row.productCode);
    let current = this.ProductDetails.find(x => x.productDetailsId === row.productDetailsId && x.productCode === row.productCode);


    this.modal.confirm({
      nzTitle: 'Are you sure delete this Item?',
      nzContent: '<b style="color: red;">Some descriptions</b>',
      nzOkText: 'Yes',
      nzOkType: 'primary',
      nzOkDanger: true,
      nzOnOk: () => {
        console.log('OK');
        if (current) {

          let indexOfCurrent = this.ProductDetails.indexOf(current);
          if (row.productDetailsId > 0) {
            this.ProductDetails[indexOfCurrent].rowStatus = 'delete';
          } else {
            this.ProductDetails.splice(indexOfCurrent, 1);
          }

        }



      },
      nzCancelText: 'No',
      nzOnCancel: () => { console.log('Cancel'); }
    });






    // var IsConfirmed = this.showDeleteConfirm('Are you sure delete this Item?');
    // if (IsConfirmed) {
    //   this.ProductDetails.splice(index, 1);
    // }
  }
}

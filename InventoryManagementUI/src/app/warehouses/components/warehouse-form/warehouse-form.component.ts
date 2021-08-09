import { WarehouseModel, Bin } from './../../models/warehouse-model';
import { Component, Input, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, FormArray, Validators } from '@angular/forms';
import { NzModalRef, NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';
import { ProductModel } from 'src/app/products/models/product-model';
import { WarehousesService } from '../../services/warehouses.service';

@Component({
  selector: 'app-warehouse-form',
  templateUrl: './warehouse-form.component.html',
  styleUrls: ['./warehouse-form.component.css']
})
export class WarehouseFormComponent implements OnInit {

  @Input() IsCreateForm: boolean = true;
  @Input() warehouse!: WarehouseModel;

  title: string = this.IsCreateForm ? "Craete Product" : "Edit Product"

  MainForm!: FormGroup;

  id!: FormControl;
  name!: FormControl;
  locationStreet!: FormControl;

  locationCity!: FormControl;
  locationState!: FormControl;
  locationZipCode!: FormControl;


  bins!: FormArray;


  constructor(private fb: FormBuilder, private whSvc: WarehousesService, private modal: NzModalService, private modalRef: NzModalRef, private toasterSvc: ToastrService) { }
  ngAfterViewInit(): void {
    debugger
    this.initForm()


  }


  ngOnInit(): void {
    debugger
    this.initForm()
  }

  initForm() {
    this.id = new FormControl(this.IsCreateForm ? 0 : this.warehouse.id);
    this.name = new FormControl(this.IsCreateForm ? '' : this.warehouse.name, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)]));
    this.locationStreet = new FormControl(this.IsCreateForm ? '' : this.warehouse.locationStreet, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(200)]));

    this.locationCity = new FormControl(this.IsCreateForm ? '' : this.warehouse.locationCity, Validators.compose([Validators.required]));
    this.locationState = new FormControl(this.IsCreateForm ? '' : this.warehouse.locationState, Validators.compose([Validators.required, Validators.minLength(3)]));

    this.locationZipCode = new FormControl(this.IsCreateForm ? '' : this.warehouse.locationZipCode, Validators.compose([Validators.required, Validators.min(1)]));

    this.bins = this.fb.array([])



    this.MainForm = this.fb.group({
      id: this.id,
      name: this.name,
      locationStreet: this.locationStreet,
      locationCity: this.locationCity,
      locationState: this.locationState,
      locationZipCode: this.locationZipCode,
      bins: this.bins

    });

    if (!this.IsCreateForm) {
      this.warehouse.bins.forEach(x => {
        this.addItem(x);
      })
    }
  }

  createItem(model?: Bin): FormGroup {
    return this.fb.group({
      id: new FormControl((this.IsCreateForm || model?.id == null) ? 0 : model?.id),
      color: new FormControl((this.IsCreateForm && model?.color != null) ? 0 : model?.color, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])),
      // depth: new FormControl('', Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])),
      name: new FormControl((this.IsCreateForm && model?.name != null) ? 0 : model?.name, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])),
      serialNumber: new FormControl((this.IsCreateForm && model?.serialNumber != null) ? 0 : model?.serialNumber, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)])),
      warehouseId: new FormControl((this.IsCreateForm || model?.warehouseId == null) ? 0 : model?.warehouseId),

    });
  }
  addItem(model?: Bin): void {
    this.bins = this.MainForm.get('bins') as FormArray;
    this.bins.push(this.createItem(model));
  }

  get WhBins() {
    return this.MainForm.get('bins') as FormArray;
  }

  OnFormSubmit() {
    this.MainForm.markAllAsTouched();
    console.log(this.MainForm);
    if (this.MainForm.valid) {

      console.log(this.MainForm.value)
      if (this.IsCreateForm) {
        this.whSvc.Create(this.MainForm.value).subscribe(res => {
          console.log(res)
          if (res) {
            this.toasterSvc.success('Successfully Created');
            this.modalRef.destroy();
          }

        })
      } else {
        this.whSvc.Update(this.MainForm.value).subscribe(res => {
          console.log(res)
          if (res) {
            this.toasterSvc.success('Successfully Updated');
            this.modalRef.destroy();
          }
        })

      }
    }
  }



  deleteControl(i: number) {
    if (this.bins.length !== 0) {
      this.bins.removeAt(i);
    }
  }


  GenerateSerialNumber(index: number) {
    let BinName = this.bins.controls[index].get('name')?.value;
    this.bins.controls[index].get('serialNumber')?.setValue(`#${index + 10}-${BinName}`);
  }

  destroyModal(): void {
    this.modalRef.destroy();
  }





}

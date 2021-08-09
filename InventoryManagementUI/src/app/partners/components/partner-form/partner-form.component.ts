import { PartnersService } from './../../services/partners.service';
import { PartnerModel } from './../../models/partner-model';
import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { NzModalRef, NzModalService } from 'ng-zorro-antd/modal';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-partner-form',
  templateUrl: './partner-form.component.html',
  styleUrls: ['./partner-form.component.css']
})
export class PartnerFormComponent implements OnInit {

  @Input() IsCreateForm: boolean = true;
  @Input() partner!: PartnerModel;

  title: string = this.IsCreateForm ? "Craete Product" : "Edit Product"

  MainForm!: FormGroup;

  id!: FormControl;
  name!: FormControl;
  phoneNumber!: FormControl;

  email!: FormControl;

  street!: FormControl;
  city!: FormControl;
  state!: FormControl;
  zipCode!: FormControl;
  country!: FormControl;






  constructor(private fb: FormBuilder, private prtSvc: PartnersService, private modal: NzModalService, private modalRef: NzModalRef, private toasterSvc: ToastrService) { }
  ngAfterViewInit(): void {
    debugger
    this.initForm()


  }


  ngOnInit(): void {
    debugger
    this.initForm()
  }

  initForm() {
    this.id = new FormControl(this.IsCreateForm ? 0 : this.partner.id);
    this.name = new FormControl(this.IsCreateForm ? '' : this.partner.name, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(50)]));


    this.phoneNumber = new FormControl(this.IsCreateForm ? '' : this.partner.phoneNumber, Validators.compose([Validators.required, Validators.min(1)]));
    this.email = new FormControl(this.IsCreateForm ? '' : this.partner.email, Validators.compose([Validators.required, Validators.email]));
    this.street = new FormControl(this.IsCreateForm ? '' : this.partner.street, Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(200)]));
    this.city = new FormControl(this.IsCreateForm ? '' : this.partner.city, Validators.compose([Validators.required]));
    this.state = new FormControl(this.IsCreateForm ? '' : this.partner.state, Validators.compose([Validators.required, Validators.minLength(3)]));
    this.zipCode = new FormControl(this.IsCreateForm ? '' : this.partner.zipCode, Validators.compose([Validators.required, Validators.minLength(3)]));
    this.country = new FormControl(this.IsCreateForm ? '' : this.partner.country, Validators.compose([Validators.required, Validators.minLength(3)]));






    this.MainForm = this.fb.group({
      id: this.id,
      name: this.name,
      phoneNumber: this.phoneNumber,
      email: this.email,
      street: this.street,
      city: this.city,
      state: this.state,
      zipCode: this.zipCode,
      country: this.country
    });
  }




  OnFormSubmit() {
    this.MainForm.markAllAsTouched();
    console.log(this.MainForm);
    if (this.MainForm.valid) {

      console.log(this.MainForm.value)
      if (this.IsCreateForm) {
        this.prtSvc.Create(this.MainForm.value).subscribe(res => {
          console.log(res)
          if (res) {
            this.toasterSvc.success('Successfully Created');
            this.modalRef.destroy();
          }

        })
      } else {
        this.prtSvc.Update(this.MainForm.value).subscribe(res => {
          console.log(res)
          if (res) {
            this.toasterSvc.success('Successfully Updated');
            this.modalRef.destroy();
          }
        })

      }
    }
  }



  destroyModal(): void {
    this.modalRef.destroy();
  }





}

import { FormControl } from '@angular/forms';
import { Component, Injector, Input, OnDestroy, OnInit } from '@angular/core';
import { FormBase } from '../../app-utils/form-base';
import { Subscription } from 'rxjs';
import { TransKeys } from '../../validators/CustomValidation';

@Component({
  selector: 'app-validation',
  templateUrl: './validation.component.html',
  styleUrls: ['./validation.component.css']
})
export class ValidationComponent extends FormBase implements OnInit,OnDestroy  {
  @Input() controle!: FormControl;
  minlength: number = 0;
  maxlength: number = 0;
  subscription$!: Subscription;

 public TransKeys=TransKeys;

  constructor(injector: Injector) {
    super(injector);
  }
  ngOnInit(): void {
     //console.log(this.controle)
    this.subscription$ = this.controle.valueChanges.subscribe(d => {

      if (this.controle.hasError(this.ValRules.Minlength)) {
        this.minlength = this.controle.getError(this.ValRules.Minlength)?.requiredLength;
      }

      if (this.controle.hasError(this.ValRules.Maxlength)) {
        this.maxlength = this.controle.getError(this.ValRules.Maxlength)?.requiredLength;
      }
    })
  }


  ngOnDestroy() {
    debugger
    console.log("----------------unsubscribe-------------------")
    this.subscription$.unsubscribe()
  }



}

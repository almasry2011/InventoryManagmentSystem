import { AbstractControl } from "@angular/forms";

export class FormUtils {

  public static SetFormControleValue(control: AbstractControl, val: any) {
    control.setValue(val)
    //  control.updateValueAndValidity();
  }



}

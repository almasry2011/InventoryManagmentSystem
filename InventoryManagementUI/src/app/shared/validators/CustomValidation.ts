import { AbstractControl, ValidationErrors } from "@angular/forms";

const numberPatern:RegExp= /^[0-9]+$/;
const arPatern:RegExp=/^[\u0600-\u06FF ]+$/;
const enPatern:RegExp=/^[a-zA-Z ]+$/;
 



export class CustomValidation {

    static ArabicOnly(control: AbstractControl): ValidationErrors | null {
        const val: string = control.value as string;
        if ( val && !arPatern.test(val)) {
          return { notArabic: true };
        }
        return {};

    }


    static EnglishOnly(control: AbstractControl): ValidationErrors | null {
        const val: string = control.value as string;
        if ( val && !enPatern.test(val)) {
          return { notEnglish: true };
        }
        return {};
    }



    static NumbersOnly(control: AbstractControl): ValidationErrors | null {
        const val: string = control.value as string;
        if ( val && !numberPatern.test(val)) {
          return { notNumbers: true };
        }
        return {};
    }

 




}
 





export enum ValidationRules {
    ArabicOnly='notArabic',
    EnglishOnly='notEnglish',
    NumbersOnly='notNumbers',
    Maxlength='maxlength',
    Minlength='minlength',
    Min='min',
    Max='max',
    Required='required',
}



export enum TransKeys{
Hello= "Hello",
Test= "Test",
RequiredKEY= "VALIDATION-MESSAGES.Required-KEY" ,
ARABICONLYKEY= "VALIDATION-MESSAGES.ARABIC-ONLY-KEY",

MINLENGTHKEY= "VALIDATION-MESSAGES.MIN-LENGTH-KEY",
MAXLENGTHKEY= "VALIDATION-MESSAGES.MAX-LENGTH-KEY",
 
MINKEY= "VALIDATION-MESSAGES.MIN-KEY",
MAXKEY= "VALIDATION-MESSAGES.MAX-KEY",

LANGKEY= "COMMON.LANG-KEY",
ARABICKEY= "COMMON.ARABIC-KEY",
ENGLISHKEY= "COMMON.ENGLISH-KEY",
DROPDOWNPLACEHOLDERKEY= "COMMON.DROPDOWN-PLACEHOLDER-KEY"

    
    
    }

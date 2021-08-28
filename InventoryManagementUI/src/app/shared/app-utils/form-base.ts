import { Injector } from "@angular/core";
import { TranslateService } from "@ngx-translate/core";
import { param } from "jquery";
import {  ValidationRules } from "../validators/CustomValidation";


export    class FormBase {
  
    protected  readonly  translation  : TranslateService;
     
 
constructor( injector: Injector ) {

    this.translation = injector.get(TranslateService);


}



public ValRules=ValidationRules;




    GetTranslation(key:string,param1:any=null,param2:any=null){
        debugger;
        // let d=this.translation.get(key)      .subscribe((data:any)=> {
        //     console.log(data);
        //    });
        // console.log("-----------------trans----------------------")
        // console.log(d)
        // console.log("-----------------trans----------------------")

  
    return   this.translation.instant(key, {param1: param1,param2: param2});
}

 

}

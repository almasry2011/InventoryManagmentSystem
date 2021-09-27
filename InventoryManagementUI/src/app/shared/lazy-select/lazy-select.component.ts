import { data } from 'jquery';
import { GetAllRequest } from './../../core/models/getall-request';
import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Injector, Input, OnInit, Output } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NzSelectModeType } from 'ng-zorro-antd/select';
import { FormControl, FormGroup } from '@angular/forms';
import { map } from 'rxjs/operators';
import { FormBase } from '../app-utils/form-base';
import { TransKeys } from '../validators/CustomValidation';
 


@Component({
  selector: 'app-lazy-select',
  templateUrl: './lazy-select.component.html',
  styleUrls: ['./lazy-select.component.css']
})
export class LazySelectComponent extends FormBase implements OnInit {



  @Input()  formGroup!: FormGroup;

  @Input()  ParentFormGroup!: FormGroup;
  @Input()  ChiledFormGroup!: FormGroup;


  
  @Input() formControlName !: string;
    
  @Input() controle!: FormControl;

  @Input() PlaceHolder!: string ;
  @Input() URL: string | undefined;
  @Input() Disabled: boolean = false;
  @Input() pageSize: number = 5;
  @Input() MultiMode: boolean = false;
  @Input() IsRequired: boolean = false;
  @Input() filter: any = null;
  @Input() fcName: any = '';
  @Input() selectedValue: any = null;
  @Input() resetAfterSelect: boolean = false;

  mode: NzSelectModeType = this.MultiMode ? 'multiple' : 'default'; //multiple //tag




  @Output() selectedOptionChange: EventEmitter<object | string> = new EventEmitter<object | string>();

  searchVal: string = ''
  page: number = 0;
  optionList: any = [];
  //selectedUser: any = null;
  isLoading = false;

  constructor(private http: HttpClient,injector:Injector) {
    super(injector);
  }

  ngOnInit(): void {
    debugger
    let fc=this.formControlName
    let controlrname=this.controle;
if(this.controle.value>0)
{
  let _endpontUrl = environment.baseUrl + this.URL
  

  let model: any = {Id:this.controle.value };



  this.http.post<any>(_endpontUrl, model)
    




  .subscribe(data => {
    debugger

    setTimeout(() => {
      this.isLoading = false;
    }, 2000);
      this.optionList = data.data;
  });
}
    // this.selectedUser = { name: 'AMR' }
    // if (this.resetAfterSelect) {
    //   this.selectedValue = {};
    // }
  }


  changed(event: any) {
    debugger
    if (event) {
      console.log(event)
      console.log(this.selectedValue)
      if (this.resetAfterSelect) {
        this.selectedValue = {};
      }
      this.selectedOptionChange.emit(event);
    }
  }


  loadMore(): void {
    debugger;
    let _endpontUrl = environment.baseUrl + this.URL

    this.isLoading = true;
    let model: GetAllRequest<null> = {
      pageNumber: this.page,
      pageSize: this.pageSize,
      search: this.searchVal,
      Filter: this.filter
    };

    this.http.post<any>(_endpontUrl, model)

    .pipe(map(items=> (items.data.filter((s:any)=>s.id!=this.controle.value)
    
    
  //   ,items.data.sort((a:any, b:any) => {
  //     debugger
  //     return a.value < b.value ? -1 : 1;
  //  })
    
    ),
   

     
    ))

      .subscribe(data => {
        
        // alert(this.optionList.length)
        //  alert(this.optionList.pageSize)
        this.page++;// //this.optionList.length / this.pageSize;
        setTimeout(() => {
          this.isLoading = false;





        }, 2000);

        this.optionList = [...this.optionList, ...data];
        if (this.searchVal) {
          this.optionList = data;
        }
      //   this.optionList=this.optionList.map((items: any[]) => items.sort((a:any, b:any) => {
      //     debugger
      //     return a.id < b.id ? -1 : 1;
      //  }))


      






        // this.optionList = [...this.optionList, ...data.data];
        // if (this.searchVal) {
        //   this.optionList = data.data;
        // }
      });
  }


  search(value: any): void {
    console.log('searchVal：', value ? value : 'nnn');
    this.page = 0;
    this.searchVal = value;
    this.loadMore();

  }


}

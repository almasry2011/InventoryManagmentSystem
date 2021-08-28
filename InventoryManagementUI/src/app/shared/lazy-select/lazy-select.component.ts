import { GetAllRequest } from './../../core/models/getall-request';
import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { environment } from 'src/environments/environment';
import { NzSelectModeType } from 'ng-zorro-antd/select';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-lazy-select',
  templateUrl: './lazy-select.component.html',
  styleUrls: ['./lazy-select.component.css']
})
export class LazySelectComponent implements OnInit {


  @Input()  formGroup!: FormGroup;
  @Input() formControlName !: string;
    

  @Input() PlaceHolder: string = "Please Select";
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

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    debugger
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
      .subscribe(data => {
        // alert(this.optionList.length)
        //  alert(this.optionList.pageSize)
        this.page++;// //this.optionList.length / this.pageSize;
        setTimeout(() => {
          this.isLoading = false;


        }, 2000);

        this.optionList = [...this.optionList, ...data.data];
        if (this.searchVal) {
          this.optionList = data.data;
        }
      });
  }


  search(value: any): void {
    console.log('searchVal：', value ? value : 'nnn');
    this.page = 0;
    this.searchVal = value;
    this.loadMore();

  }


}

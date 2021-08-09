import { Component, OnDestroy, OnInit, ViewChild } from '@angular/core';
import { Observable, of, Subject, Subscription } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SearchCriteria } from '../../models/search-criteria';
import { DataTableDirective } from 'angular-datatables';
import { HttpClient } from '@angular/common/http';
import { ProductModel } from 'src/app/products/models/product-model';
import { GetAllRequest } from '../../models/getall-request';
import { LazyLoadEvent, SelectItem } from 'primeng/api';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-base',
  templateUrl: './base.component.html',
  styleUrls: ['./base.component.css']
})
export class BaseComponent<T> implements OnInit, OnDestroy {
  private baseUrl: string = environment.baseUrl;
  // dtOptions: DataTables.Settings = {};
  dtOptions: any = {};
  searchCriteria: SearchCriteria = { isPageLoad: false, filter: '' };
  dtTrigger: Subject<any> = new Subject();
  isDtInitialized: boolean = false;

  @ViewChild(DataTableDirective) dtElement!: DataTableDirective;

  timerSubscription!: Subscription;

  PaggedData!: T[];
  SearchVal!: string;
  constructor(private http: HttpClient) { }

  ngOnInit(): void {

    //this.load(0, "");

  }

  load(page: number, search: string): any {

    let model: GetAllRequest<any> = {
      pageNumber: page,
      pageSize: 50,
      search: search,
      Filter: []
    };
    this.http.post<any>(`${this.baseUrl}/Product/GetAllFiltered`, model)
      .subscribe(s => {
        console.log(s)
        this.products = s.data
      })
      ;


  }


  lazyItems!: SelectItem[];



  selectedLazy!: SelectItem;

  filterValue!: string;



  onLazyLoadEvent(event: any) {
    debugger;
    this.loadBatch(event).subscribe(res => {
      this.lazyItems = res;
    });
  }

  loadBatch(event: LazyLoadEvent): Observable<SelectItem[]> {
    // simulate server response event.globalFilter
    let res: any = [];


    debugger;
    console.log(event)
    let model: GetAllRequest<any> = {
      pageNumber: event.first,
      pageSize: 20,

    };

    this.http.post<any>(`${this.baseUrl}/Product/GetAllFiltered`, model)
      .subscribe(s => {
        console.log(s)
        this.products = [...s.data]
        res = [...s.data]
      });


    // for (let i = 0; i < this.items.length; i++) {
    //     if (!event.globalFilter || (event.globalFilter && this.items[i].label.includes(event.globalFilter))) {
    //         res.push({...this.items[i]});
    //     }


    //     if (event.rows === res.length) {
    //         break;
    //     }
    // }
    return of(res);
  }








  loadCarsLazy(event: LazyLoadEvent) {

    debugger;
    console.log(event)
    let model: GetAllRequest<any> = {
      pageNumber: event.first,
      pageSize: 5,

    };

    this.http.post<any>(`${this.baseUrl}/Product/GetAllFiltered`, model)
      .subscribe(s => {
        console.log(s)
        this.products = [...s.data]
      });


    // //simulate remote connection with a timeout
    // setTimeout(() => {
    //     //load data of required page
    //     let loadedCars = this.products.slice(event.first, (event.first + event.rows));

    //     //populate page of virtual cars
    //     Array.prototype.splice.apply(this.virtualCars, [...[event.first, event.rows], ...loadedCars]);

    //     //trigger change detection
    //     this.virtualCars = [...this.virtualCars];
    // }, 1000);


  }



  randomUserUrl = 'https://api.randomuser.me/?results=10';
  optionList: string[] = [];
  selectedUser = null;
  isLoading = false;
  pageNumber = 0;

  getRandomNameList: Observable<string[]> = this.http
    .get(`${this.randomUserUrl}`)
    .pipe(map((res: any) => res.results))
    .pipe(
      map((list: any) => {
        return list.map((item: any) => `${item.name.first}`);
      })
    );

  loadMore(): void {
    this.isLoading = true;

    let model: GetAllRequest<any> = {
      pageNumber: this.pageNumber,
      pageSize: 5,

    };

    this.http.post<any>(`${this.baseUrl}/Product/GetAllFiltered`, model)
      .subscribe(s => {
        console.log(s)
        this.isLoading = false;
        this.pageNumber++;
        this.optionList = [...this.optionList, ...s.data];
      });


    // this.getRandomNameList.subscribe(data => {
    //   this.isLoading = false;
    //   this.optionList = [...this.optionList, ...data];
    // });
  }

















  ////

  InitDt(endPoint: string, columns: any): void {
    this.dtOptions = {
      pagingType: 'full_numbers',
      pageLength: 5,
      serverSide: true,
      processing: true,
      searching: false,
      autoWidth: true,
      lengthMenu: [5, 10, 25, 50, 75, 100],
      initComplete: function (settings: any, json: any) {
        $('div.loading').remove();

      },

      // dom: 'Bfrtip',
      // // Configure the buttons
      // buttons: [
      //   'columnsToggle',
      //   'colvis',
      //   'copy',
      //   'print',
      //   'excel',
      //   {
      //     text: 'Some button',
      //     key: '1',
      //     action: function (e: any, dt: any, node: any, config: any) {
      //       alert('Button activated');
      //     }
      //   }
      // ],

      // dom: 'Bfrtip',
      // //buttons: ['copy', 'csv', 'excel', 'print'],
      // buttons: [
      //   //'copy',

      //   'print',
      //   'csv',
      //   'columnsToggle',
      //   'colvis',
      //   'pdf',
      //   'excel',
      // ],


      ajax: (dataTablesParameters: any, callback: any) => {
        // debugger;
        dataTablesParameters.searchCriteria = this.searchCriteria;
        this.http
          .post<any>(this.baseUrl + '/' + endPoint, dataTablesParameters, {})
          .subscribe((resp) => {
            console.log(resp);
            this.PaggedData = resp.data;

            this.isDtInitialized = true;
            callback({
              recordsTotal: resp.recordsTotal,
              recordsFiltered: resp.recordsFiltered,
              data: [],
            });
          });
      },

      columns: columns,
    };
  }

  CallngAfterViewInit(): void {
    this.dtTrigger.next();
  }

  rerender(): void {
    // debugger;
    this.searchCriteria.isPageLoad = false;
    this.searchCriteria.filter = this.SearchVal;
    if (this.isDtInitialized) {
      this.dtElement.dtInstance.then((dtInstance: DataTables.Api) => {
        dtInstance.destroy();
        this.dtTrigger.next();
      });
    } else {
      this.isDtInitialized = true;
      this.dtTrigger.next();
    }
  }

  search() {
    this.rerender();
  }

  ngOnDestroy(): void {
    this.dtTrigger.unsubscribe();

    if (this.timerSubscription) {
      this.timerSubscription.unsubscribe();
    }
  }

  private refreshData(): void {
    this.rerender();
    this.subscribeToData();
  }

  private subscribeToData(): void {
    this.refreshData();
  }


  ///
  products!: ProductModel[];



  ///
}


function PagedResponse<T>(arg0: string) {
  throw new Error('Function not implemented.');
}


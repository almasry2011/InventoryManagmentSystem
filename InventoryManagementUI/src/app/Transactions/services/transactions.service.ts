import { TransactionModel } from './../models/transaction-model';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { PagedResponse, response } from 'src/app/core/models/paged-response';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TransactionsService {

  private baseUrl: string = environment.baseUrl + '/Transaction';
  constructor(private http: HttpClient) { }

  GetAllFiltered(pageNumber: number, pageSize: number, search: string = ""): Observable<PagedResponse<TransactionModel>> {
    return this.http.get<PagedResponse<TransactionModel>>(`${this.baseUrl}/GetAllFiltered?pageNumber=${pageNumber}&pageSize=${pageSize}&search=${search}`);
  }
  getById(id: number): Observable<response<TransactionModel>> {
    return this.http.get<response<TransactionModel>>(`${this.baseUrl}/${id}`);
  }

  Create(model: TransactionModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/NewSaleTransaction`, model);
  }




  SaleTransaction(model: TransactionModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/SaleTransaction`, model);
  }


  ProcurementTransaction(model: TransactionModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/ProcurementTransaction`, model);
  }

  PurchaseTransaction(model: TransactionModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/PurchaseTransaction`, model);
  }

  Update(model: TransactionModel): Observable<boolean> {
    return this.http.put<any>(`${this.baseUrl}/Update?id=${model.id}`, model);
  }

  Delete(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }
}

import { WarehouseModel } from './../models/warehouse-model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { PagedResponse, response } from 'src/app/core/models/paged-response';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WarehousesService {


  private baseUrl: string = environment.baseUrl + '/Warehouse';
  constructor(private http: HttpClient) { }

  GetAllFiltered(pageNumber: number, pageSize: number, search: string = ""): Observable<PagedResponse<WarehouseModel>> {
    return this.http.get<PagedResponse<WarehouseModel>>(`${this.baseUrl}/GetAllFiltered?pageNumber=${pageNumber}&pageSize=${pageSize}&search=${search}`);
  }
  getById(id: number): Observable<response<WarehouseModel>> {
    return this.http.get<response<WarehouseModel>>(`${this.baseUrl}/${id}`);
  }

  Create(model: WarehouseModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/Create`, model);
  }

  Update(model: WarehouseModel): Observable<boolean> {
    return this.http.put<any>(`${this.baseUrl}/Update?id=${model.id}`, model);
  }

  Delete(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }


}

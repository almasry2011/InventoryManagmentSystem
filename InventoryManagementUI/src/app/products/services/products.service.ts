import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PagedResponse, response } from 'src/app/core/models/paged-response';
import { environment } from 'src/environments/environment';
import { ProductCreateModel } from '../models/product-create-model';
import { ProductModel } from '../models/product-model';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  private baseUrl: string = environment.baseUrl + '/product';
  constructor(private http: HttpClient) { }

  GetAllFiltered(pageNumber: number, pageSize: number, search: string = ""): Observable<PagedResponse<ProductModel>> {
    return this.http.get<PagedResponse<ProductModel>>(`${this.baseUrl}/GetAllFiltered?pageNumber=${pageNumber}&pageSize=${pageSize}&search=${search}`);
  }
  getProduct(id: number): Observable<response<ProductModel>> {
    return this.http.get<response<ProductModel>>(`${this.baseUrl}/${id}`);
  }

  CreateProduct(model: ProductCreateModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/Create`, model);
  }

  UpdateProduct(model: ProductModel): Observable<boolean> {
    return this.http.put<any>(`${this.baseUrl}/Update?id=${model.id}`, model);
  }

  DeleteProduct(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }
}

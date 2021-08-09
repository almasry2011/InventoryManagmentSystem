import { PartnerModel } from './../models/partner-model';

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PagedResponse, response } from 'src/app/core/models/paged-response';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PartnersService {

  private baseUrl: string = environment.baseUrl + '/Partner';
  constructor(private http: HttpClient) { }

  GetAllFiltered(pageNumber: number, pageSize: number, search: string = ""): Observable<PagedResponse<PartnerModel>> {
    return this.http.get<PagedResponse<PartnerModel>>(`${this.baseUrl}/GetAllFiltered?pageNumber=${pageNumber}&pageSize=${pageSize}&search=${search}`);
  }
  getById(id: number): Observable<response<PartnerModel>> {
    return this.http.get<response<PartnerModel>>(`${this.baseUrl}/${id}`);
  }

  Create(model: PartnerModel): Observable<boolean> {
    return this.http.post<any>(`${this.baseUrl}/Create`, model);
  }

  Update(model: PartnerModel): Observable<boolean> {
    return this.http.put<any>(`${this.baseUrl}/Update?id=${model.id}`, model);
  }

  Delete(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }

}

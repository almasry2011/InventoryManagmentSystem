import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PagedResponse, response } from 'src/app/core/models/paged-response';

import { environment } from 'src/environments/environment';
import { DashboardModel } from '../models/DashboardModel';


@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  private baseUrl: string = environment.baseUrl + '/dashboard';
  constructor(private http: HttpClient) { }


  GetDashboardData(): Observable<DashboardModel> {
    return this.http.get<DashboardModel>(`${this.baseUrl}/GetDashboardData`);
  }


}

import { HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HttpInterceptorService {

  // constructor() { }


  constructor(private router: Router, private spinner: NgxSpinnerService) {

  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    debugger
    //  this.spinner.show();
    if (localStorage.getItem('jwt') != null) {
      const clonedReq = req.clone({
        headers: req.headers.set('Authorization', 'Bearer ' + localStorage.getItem('jwt'))
      });
      return next.handle(clonedReq).pipe(
        tap(
          succ => {

            setTimeout(() => {
              /** spinner ends after 5 seconds */
              this.spinner.hide();
            }, 200);

          },
          err => {
            if (err.status == 401) {
              localStorage.removeItem('jwt');
              this.router.navigateByUrl('');
            }
            else if (err.status == 403) {
              this.router.navigateByUrl('/forbidden');
            }
          }
        )
      )
    }
    else
      setTimeout(() => {
        /** spinner ends after 5 seconds */
        this.spinner.hide();
      }, 2000);

    //  return next.handle(req.clone());




    return next.handle(req.clone()).pipe(
      tap(
        succ => {

          setTimeout(() => {
            /** spinner ends after 5 seconds */
            this.spinner.hide();
          }, 2000);

        },
        err => {
          if (err.status == 401) {
            localStorage.removeItem('jwt');
            this.router.navigateByUrl('');
          }
          else if (err.status == 403) {
            this.router.navigateByUrl('/forbidden');
          }
        }
      )
    )







  }



}

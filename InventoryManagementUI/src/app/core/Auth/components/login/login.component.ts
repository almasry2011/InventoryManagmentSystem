
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { LoginRequestModel } from './../../models/login-request-model';

import { AuthService } from './../../services/auth.service';





@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private authSrv: AuthService,
    private toastrSvc: ToastrService,
    private router: Router
  ) { }

  ngOnInit(): void { }

  model: LoginRequestModel = {};

  login() {
    debugger;
    this.authSrv.Login(this.model).subscribe(
      (data: any) => {
        console.log(data);
        if (data.succeeded) {
          this.toastrSvc.success('Login Success');
          this.router.navigate(['/']);
        } else {
          this.toastrSvc.error(data.message);
        }
      },
      (error: any) => {
        console.log(error);
        this.toastrSvc.error(error.message);
      }
    );
    console.log(this.model);
  }
}

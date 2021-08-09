import { ToastrService } from 'ngx-toastr';
import { AuthService } from './../../services/auth.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RegisterRequestModel } from '../../models/register-request-model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(
    private authSrv: AuthService,
    private toastrSvc: ToastrService,
    private router: Router
  ) { }
  errors: Array<string> = [];
  model: RegisterRequestModel = {};
  ngOnInit(): void { }

  Register() {
    console.log(this.model);
    this.authSrv.Register(this.model).subscribe(
      (res) => {
        console.log(res);
        debugger;
        if (res.succeeded) {
          this.toastrSvc.success('Successfully Registerd ');
          this.router.navigate(['/auth/login']);
        } else {
          this.toastrSvc.error('Validation Errors');
          this.errors = [];
          this.errors.push(res.errors);
        }
      },
      (error) => {
        debugger;
        console.log(error);
        this.errors = [];
        this.errors.push(error.error.errors);
      }
    );
  }

}

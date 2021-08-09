import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginResponseModel } from '../../Auth/models/login-response-model';
import { AuthService } from '../../Auth/services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router, private authSrv: AuthService) { }
  isLoggedIn: boolean = false;
  LoginData!: LoginResponseModel;
  ngOnInit(): void {
    this.authSrv.isLoggesIn.subscribe(res => this.isLoggedIn = res);
    this.authSrv.GetUserData();

  }
  signOut() {
    this.authSrv.signOut();
    this.router.navigate(['/auth/login']);
  }

}

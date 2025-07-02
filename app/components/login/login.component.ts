import { Component, OnInit } from '@angular/core';
import { UiService } from 'app/services/ui.service';

const LOGIN: string = 'Login';
const REGISTER: string = 'Register';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  uname: string | undefined;
  psw: string | undefined;
  email: string | undefined;

  //initialize button, link, and login state
  submitButtonText: string = LOGIN;
  toggleButtonText: string = REGISTER;
  isLoggingIn: boolean = true;

  constructor(private uiService: UiService ) {}
  ngOnInit(): void {}

  onSubmit():void{
    if (this.isLoggingIn) {
      if (this.uname === undefined || this.psw === undefined) {
        alert("Please ensure both username and password are filled in");
      }
      else {
        this.uiService.attemptLogin({
          username: this.uname,
          password: this.psw
        });
      }
    }
    else {
      if (this.uname === undefined || this.psw === undefined || this.email === undefined) {
        alert("Please ensure username, password, and email are filled in");
      }
      else {
        this.uiService.attemptRegister({
          username: this.uname,
          password: this.psw,
          email: this.email
        });
      }
    }
  }
  
  onToggle(): void {
    // toggle login and register
    this.isLoggingIn = !this.isLoggingIn;
    if (this.isLoggingIn) {
      this.submitButtonText = LOGIN;
      this.toggleButtonText = REGISTER;
    }
    else {
      this.submitButtonText = REGISTER;
      this.toggleButtonText = LOGIN;
    }
  }
}

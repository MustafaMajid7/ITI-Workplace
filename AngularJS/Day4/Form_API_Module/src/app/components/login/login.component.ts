import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl,Validators } from '@angular/forms';
import { LoginAPIService } from 'src/app/services/login-api.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  data:any;

  constructor(public api :LoginAPIService){}
  
  ngOnInit(): void {
    this.api.getAllusers().subscribe({
      next:(response:any)=>{
        this.data = response;        
      },
      error:()=>{},
      complete:()=>{}
    });
  }

  loginForm = new FormGroup({
    username: new FormControl("",[Validators.required,Validators.pattern("^[a-zA-Z]{3,}$")]),
    password: new FormControl("",[Validators.required,Validators.minLength(7)])
  })
  
  checkData(e:Event):any{
    e.preventDefault();
    
    for (const value in this.data) {
      if(this.loginForm.value.username==this.data[value].username &&
         this.loginForm.value.password==this.data[value].password)
        {
          alert("you login successfully")
          return;
        }
    } 
    alert("username or password are invalid")
  }

  get usernameFunc():boolean{
    return this.loginForm.controls['username'].status == 'INVALID';
  }
  get passwordFunc():boolean{
    return this.loginForm.controls['password'].status == 'INVALID';
  }
}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginAPIService {

  constructor(public http: HttpClient) { }

  getAllusers():any{
    return this.http.get("http://localhost:3000/users")
  }
  getUserByID(id:number):any{
    return this.http.get("http://localhost:3000/users/"+id)
  }
  
}

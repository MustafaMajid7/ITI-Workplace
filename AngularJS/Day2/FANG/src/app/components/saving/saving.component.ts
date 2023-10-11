import { Component } from '@angular/core';

@Component({
  selector: 'app-saving',
  templateUrl: './saving.component.html',
  styleUrls: ['./saving.component.css']
})
export class SavingComponent {
  name:string = "";
  age:number =0;
  nameFlag:boolean=false;
  ageFlag:boolean=false;
  DuplicateFlag:boolean=false;
  data:{name:string,age:number}[]=[];

  save(){
      if(!this.checkDuplication() && !this.nameFlag && !this.ageFlag){
        this.data.push({name:this.name,age:this.age})    
        this.name=""
        this.age=0      
      }
  }
  checkDuplication():boolean{
    this.data.forEach(element => {
      this.DuplicateFlag = this.name.toLowerCase() == element.name.toLowerCase() && this.age == element.age?true:false;
    });
    return this.DuplicateFlag;
  }
  delete(index:number){
    this.data.splice(index,1) 
  }
  checkName(){
    this.nameFlag = this.name.length<3?true:false;    
  }
  checkAge(){
    this.ageFlag = this.age<18?true:false;
  }
}

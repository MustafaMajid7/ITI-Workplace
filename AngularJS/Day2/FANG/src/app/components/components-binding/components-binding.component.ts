import { Component } from '@angular/core';

@Component({
  selector: 'app-components-binding',
  templateUrl: './components-binding.component.html',
  styleUrls: ['./components-binding.component.css']
})
export class ComponentsBindingComponent {

  PageNumber:number = 0;

  linkNumber(link:number):void{
    this.PageNumber = link;
  }
  
}

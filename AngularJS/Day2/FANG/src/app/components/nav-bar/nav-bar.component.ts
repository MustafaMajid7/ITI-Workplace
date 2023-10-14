import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent {

  link:number=0;

  @Output() myEvent = new EventEmitter();

  sendData(linkNumber:number): void {
    this.link= linkNumber;
    this.myEvent.emit(this.link);
  }

}

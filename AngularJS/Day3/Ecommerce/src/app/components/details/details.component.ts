import { ProductService } from './../../services/product.service';
import { products } from './../../models/products';
import { Component, EventEmitter, Input, OnChanges, Output, SimpleChanges } from '@angular/core';
import { Iproduct } from 'src/app/models/iproduct';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnChanges {
  
  @Input() productID:number=0;
  @Output() myevent = new EventEmitter();
  closeWindow:boolean = true;

  product:Iproduct|undefined ;

  constructor(public productService:ProductService){}
  
  ngOnChanges(changes: SimpleChanges): void {
    this.product = this.productService.getProductByID(this.productID);
  }

  Close(){
    this.myevent.emit(false);
  }
  

}

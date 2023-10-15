import { ProductService } from './../../services/product.service';
import { Iproduct } from 'src/app/models/iproduct';
import { Component } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {

  detailsVisibility:boolean =false;
  productID:number=0;

  constructor(public productService:ProductService){}

  products:Iproduct[]|undefined=this.productService.getAllProducts();

  sendProductID(id:number){
    this.detailsVisibilityFun(true);
    this.productID = id;
  }
  detailsVisibilityFun(visibility:boolean){
    this.detailsVisibility = visibility;
  }

}

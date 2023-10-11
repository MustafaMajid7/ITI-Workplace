import { Component } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
  products:{name:string,price:number,quantity:number,imgSrc:string}[]=[
    {name:"Watch 1",price:200,quantity:1,imgSrc:"/assets/img/product (2).jpg"},
    {name:"Watch 2",price:500,quantity:3,imgSrc:"./../../../assets/img/product (3).jpg"},
    {name:"Watch 3",price:800,quantity:0,imgSrc:"./../../../assets/img/product (4).jpg"},
    {name:"Watch 4",price:1200,quantity:1,imgSrc:"./../../../assets/img/product (5).jpg"},
    {name:"Watch 5",price:2000,quantity:5,imgSrc:"./../../../assets/img/product (6).jpg"}
  ]
  buyProduct(i:number){
    this.products[i].quantity--;
  }
}

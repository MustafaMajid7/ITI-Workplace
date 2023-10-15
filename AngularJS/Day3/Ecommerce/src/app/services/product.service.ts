import { products } from '../models/products';
import { Injectable } from '@angular/core';
import { Iproduct } from '../models/iproduct';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  products : Iproduct[] = products;
  constructor() { }

  getAllProducts():Iproduct[]{
    return this.products
  }

  getProductByID(ID:number):Iproduct{
    const p:Iproduct|undefined = products.find(x=>x.id==ID); 
    return p==undefined? {id:0,name:"",category:"",price:0,image:""}:p;
  }

  addProduct(product:Iproduct){
    product.id = products.length +1;
    products.push(product);
  }
  editProduct(product:Iproduct){
    const index:number = products.findIndex(x=>x.id == product.id);
    products[index] = product;
  }
  deleteProduct(ID:number){
    this.products.splice(this.products.findIndex(x=>x.id == ID),1)
  }
}

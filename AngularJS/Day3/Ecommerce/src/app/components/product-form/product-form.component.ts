import { Iproduct } from 'src/app/models/iproduct';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {

  edit:boolean=false;
  product:Iproduct={id:0,name:"",category:"",price:0,image:""};

  constructor(public productService:ProductService,public router:Router,public activatedRoute:ActivatedRoute){}
  
  ngOnInit(): void {
    const x = this.activatedRoute.snapshot.params["id"];    
    if (x) {
      this.edit=true;
      this.product = this.productService.getProductByID(x);
    }    
  }

  addProduct(e:any){
    e.preventDefault();
    if(!this.edit){
      this.productService.addProduct(this.product);
    }
    this.router.navigate(['products']);
  }

}

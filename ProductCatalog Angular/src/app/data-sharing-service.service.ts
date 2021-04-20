import { Injectable } from '@angular/core';
import { Iproduct } from './product/IProduct';

@Injectable({
  providedIn: 'root'
})
export class DataSharingServiceService {

  constructor() { }

  products:Iproduct[]=[];
  updateproducts(p:Iproduct){
  this.products.push(p);  
  }
}

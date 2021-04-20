import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataSharingServiceService } from '../data-sharing-service.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  constructor(private datasharingservice : DataSharingServiceService) { }

   EnterProductForm:FormGroup ;
   updateproduct(){
    console.log(this.EnterProductForm.value);
    this.datasharingservice.updateproducts(this.EnterProductForm.value);
    this.EnterProductForm.reset();
  }
  ngOnInit(): void {
    this.EnterProductForm= new FormGroup({
      Id: new FormControl(null,[Validators.required]),
      Name: new FormControl(null,[Validators.required]),
      Manufacturer: new FormControl(null,[Validators.required]),
      Description: new FormControl(null,[Validators.required]),
      SellingPrice: new FormControl(null,[Validators.required]),
      Category: new FormControl(null,[Validators.required]),
      ShortCode: new FormControl(null,[Validators.required]),
    })
  }
  reset():void{
    this.EnterProductForm.reset();
  }

}

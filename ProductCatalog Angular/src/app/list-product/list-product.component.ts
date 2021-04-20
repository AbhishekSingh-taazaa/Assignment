import { Component, OnInit } from '@angular/core';
import { DataSharingServiceService } from '../data-sharing-service.service';
import { Iproduct } from '../product/IProduct';

@Component({
  selector: 'app-list-product',
  templateUrl: './list-product.component.html',
  styleUrls: ['./list-product.component.css']
})
export class ListProductComponent implements OnInit {

  constructor(private datasharingservice : DataSharingServiceService) { }
  AllProducts:Iproduct[]= this.datasharingservice.products;
  ngOnInit(): void {
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderDetail } from 'app/OrderDetail';
import { Product } from 'app/Product';
import { OrdersService } from 'app/services/orders.service';
import { Observable, map } from 'rxjs';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})

export class CartComponent implements OnInit {
  totalPrice: number = 0.00;
  _itemsInCart: OrderDetail[] = []

  constructor(private router: Router, private ordersService: OrdersService) {}

  ngOnInit(): void {
    console.log("subscribing")
    this.ordersService.whenLocalInCartSubjectChanges().subscribe(arr => this._itemsInCart = arr)
    // tally up all prices for all items in cart
    this._itemsInCart.forEach(element => this.totalPrice += element.totalPriceForProduct);
  }

  //this function will send us tot he checkoutpage;
  handleGoToCheckout(): void{
    this.router.navigate(['/checkout']);
  }
  //this function will delete all items from the itemsInCart[]
  handleClearCart(): void{
    this.ordersService.addOrderDetailLocally([]);
    this.totalPrice = 0.00;
    console.log("cart cleared", this._itemsInCart)
  }
}

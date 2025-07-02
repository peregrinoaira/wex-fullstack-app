import { Component, Input, OnInit } from '@angular/core';
import { Order } from 'app/Order';
import { Product } from 'app/Product';
import { User } from 'app/User';
import { UiService } from 'app/services/ui.service';
import { OrdersService } from 'app/services/orders.service';
import { OrderHistory } from 'app/OrderHistory';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.css']
})
export class OrdersComponent implements OnInit {
  currentUser: User = {
    id: 0,
    username: 'Guest',
    email: 'Unknown',
    password: '',
    isAdmin: false,
    isShopKeeper: false,
    isCustomer: true,
    token: 0
  }

  selectedOrderHistory: OrderHistory = {
    orderDetailsList: [],
    orderNumId: '',
    orderTotal: 0
  }

  orders: OrderHistory[] | undefined = [];
  products: Product [] = [];

  constructor(private uiService: UiService, private ordersService: OrdersService) {}

  ngOnInit(): void {
    this.uiService.subscribeToUserChanges().subscribe(user => this.currentUser = user);
    if (this.currentUser.id === undefined) {
      console.log("Our records indicate that you do not exist. Sorry.")
    }
    else {
      this.ordersService.getAllOrders(this.currentUser.id).subscribe(res => this.orders = res);
    }
  }

  handleSeeOrder(order: OrderHistory): void {
    this.selectedOrderHistory = order;
    console.log(this.selectedOrderHistory)
  }

}
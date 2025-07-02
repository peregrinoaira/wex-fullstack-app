import { Component, OnInit } from '@angular/core';
import { OrderDetail } from 'app/OrderDetail';
import { OrdersService } from 'app/services/orders.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.css']
})
export class CheckoutComponent implements OnInit {
  order: OrderDetail [] = [];

  constructor(private ordersService: OrdersService, private router: Router) { }

  ngOnInit(): void {
    this.ordersService.whenLocalInCartSubjectChanges().subscribe(arr => this.order = arr);
  }

onSubmit(): void {
  this.ordersService.attemptSubmitOrder(this.order);
  // If everything is rainbows and unicors, route to products with a friendly message
  // If everything falls apart, weep bitterly
  this.router.navigate(['/products']);
}

}

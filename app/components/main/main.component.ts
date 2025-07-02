import { Component, OnInit, Input } from '@angular/core';
import { User } from 'app/User';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
  @Input() currentUser: User = {
    id: 0,
    username: 'Guest',
    email: 'Unknown',
    password: '',
    isAdmin: false,
    isShopKeeper: false,
    isCustomer: true,
    token: 0
  }

  constructor() {}
  ngOnInit(): void {}
}

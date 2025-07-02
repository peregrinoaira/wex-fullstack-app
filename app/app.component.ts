import { Component, OnInit } from '@angular/core';
// import { Observable } from 'rxjs';
import { UiService } from './services/ui.service';
import { User } from './User';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'wex-fs-22-team-2-fe';
  
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

constructor(private uiService: UiService) { }

  ngOnInit(): void {
    this.uiService.subscribeToUserChanges().subscribe(user => this.currentUser = user);
  }
}

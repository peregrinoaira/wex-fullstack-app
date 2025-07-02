import { Component, OnInit, Input } from '@angular/core';
import { MatIconModule } from '@angular/material/icon';
import { UiService } from 'app/services/ui.service';
import { User } from 'app/User';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})

export class HeaderComponent implements OnInit {
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

  // this will be dynamically set in ngOnInit to current user initials
  constructor(private uiService: UiService) { }
  ngOnInit(): void { }

  onLogout(): void {
      this.uiService.attemptLogout(this.currentUser)
  }
}

import { Component, OnInit } from '@angular/core';
import { UiService } from 'app/services/ui.service';
import { UserService } from 'app/services/user.service';
import { User } from 'app/User';
import { UserCreateDataTransport } from 'app/UserCreateDataTransport';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-edit-user',
  templateUrl: './edit-user.component.html',
  styleUrls: ['./edit-user.component.css']
})
export class EditUserComponent implements OnInit {
  usersAll: User[] | undefined;
  defaultUser: User = {
    id: 0,
    username: '',
    email: '',
    password: '',
    isAdmin: false,
    isShopKeeper: false,
    isCustomer: true,
    token: 0
  }

  selectedUser: User = {
    id: 0,
    username: '',
    email: '',
    password: '',
    isAdmin: false,
    isShopKeeper: false,
    isCustomer: true,
    token: 0
  }

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
  
  userToTransport: UserCreateDataTransport = {
    isAdmin: false,
    localuserid: 0,
    userToCreate: this.defaultUser
  }

  userAuth: string = 'C';

  constructor(private uiService: UiService, private userService:UserService) {
    this.uiService.attemptGetUsers()
    this.uiService.whenListOfUsersSubjectChanges().subscribe(arr => this.usersAll = arr);
    this.uiService.subscribeToUserChanges().subscribe(user => this.currentUser = user)
    if (this.currentUser.isCustomer || this.currentUser.isShopKeeper) {
      this.selectedUser = this.currentUser;
    }
   }

  ngOnInit(): void {}

  onSave():void{
    alert("Form Successfully Saved")
  }
  handleSeeUser(aUser: User){
    this.selectedUser = aUser;
    console.log(this.selectedUser)
    if (this.selectedUser.isAdmin) this.userAuth = 'A'
    if (this.selectedUser.isShopKeeper) this.userAuth = 'S'
    if (this.selectedUser.isCustomer) this.userAuth = 'C'
  }

  onEditUser(): void {
    console.log("edit clicked");
    // submit changes was clicked. if userId = 0 postNewUser
    // if userId != 0, put existing user
    if (this.userAuth.toUpperCase() === 'A' ||
        this.userAuth.toUpperCase() === 'C' ||
        this.userAuth.toUpperCase() === 'S') {

      if (this.selectedUser.id === 0) {
        this.userService.postNewUser(this.selectedUser, this.currentUser.isAdmin).subscribe(() => {
          this.uiService.attemptGetUsers();
          this.selectedUser = this.defaultUser;
        });
      }
      else {
        console.log("trying to change the password");
        if (this.currentUser.id !== undefined) {
          this.userToTransport.isAdmin = this.currentUser.isAdmin;
          this.userToTransport.localuserid = this.currentUser.id;
          this.userToTransport.userToCreate.id = this.selectedUser.id;
          this.userToTransport.userToCreate.email = this.selectedUser.email;
          this.userToTransport.userToCreate.username = this.selectedUser.username;
          this.userToTransport.userToCreate.password = this.selectedUser.password;
          switch (this.userAuth) {
            case 'A': {
              this.userToTransport.userToCreate.isAdmin = true;
              this.userToTransport.userToCreate.isShopKeeper = false;
              this.userToTransport.userToCreate.isCustomer = false;
              break;
            }
            case 'C': {
              this.userToTransport.userToCreate.isAdmin = false;
              this.userToTransport.userToCreate.isShopKeeper = false;
              this.userToTransport.userToCreate.isCustomer = true;
              break;
            }
            case 'S': {
              this.userToTransport.userToCreate.isAdmin = false;
              this.userToTransport.userToCreate.isShopKeeper = true;
              this.userToTransport.userToCreate.isCustomer = false;
              break;
            }
            default: {
              this.userToTransport.userToCreate.isAdmin = false;
              this.userToTransport.userToCreate.isShopKeeper = false;
              this.userToTransport.userToCreate.isCustomer = true;
              break;
            }
          }
          this.userService.updateExistingUser(this.userToTransport).subscribe(() => {
            this.uiService.attemptGetUsers();
            this.selectedUser = this.defaultUser;
          });
        }
      }
    }
    else {
      alert("Please choose A = Admin, C = Customer, S = Shopkeeper");
    }
  }

  onDeleteUser(): void {
    if (this.selectedUser.id === 0 || 
        this.selectedUser.id === undefined  || 
        (this.currentUser.isAdmin && (this.selectedUser.id === this.currentUser.id))) {
      console.log("I can't even with you right now");
    }
    else if (this.selectedUser.id === this.currentUser.id) {
      this.uiService.attemptLogout(this.currentUser);
      this.userService.deleteExistingUser(this.selectedUser.id)
        .subscribe(() => {
          this.uiService.attemptGetUsers();
          this.selectedUser = this.defaultUser;
        });
    }
    else {
      this.userService.deleteExistingUser(this.selectedUser.id)
        .subscribe(() => {
          this.uiService.attemptGetUsers();
          this.selectedUser = this.defaultUser;
        });
    }
  }

  blankUser(): void {
    this.selectedUser = this.defaultUser;
    this.uiService.attemptGetUsers();
  }

  adamTest(obj: any) {
    console.log(obj);
  }
}

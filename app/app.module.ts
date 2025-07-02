import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { HeaderComponent } from './components/header/header.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { ToolbarComponent } from './components/toolbar/toolbar.component';
import { ProductComponent } from './components/product/product.component';
import { ProductsComponent } from './components/products/products.component';
import { CheckoutComponent } from './components/checkout/checkout.component';
import { EditUserComponent } from './components/edit-user/edit-user.component';
import { UsersComponent } from './components/users/users.component';
import { CouponsComponent } from './components/coupons/coupons.component';
import { EditProductComponent } from './components/edit-product/edit-product.component';
import { EditCouponComponent } from './components/edit-coupon/edit-coupon.component';
import { CartComponent } from './components/cart/cart.component';
import { MainComponent } from './components/main/main.component';
import { OrdersComponent } from './components/orders/orders.component';
import { ProductCategoryComponent } from './components/product-category/product-category.component';
import { ShopkeepComponent } from './components/shopkeep/shopkeep.component';
import { AppRoutingModule } from './app-routing.module';

// project dependencies
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatOptionModule, MatOptionSelectionChange } from '@angular/material/core';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card'
import { MatExpansionModule } from '@angular/material/expansion'
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { RouterModule } from '@angular/router';
import {MatDialogModule} from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HeaderComponent,
    SidebarComponent,
    ToolbarComponent,
    ProductComponent,
    ProductsComponent,
    CheckoutComponent,
    EditUserComponent,
    UsersComponent,
    CouponsComponent,
    EditProductComponent,
    EditCouponComponent,
    CartComponent,
    MainComponent,
    ShopkeepComponent,
    OrdersComponent,
    ProductCategoryComponent
  ],
  
  imports: [
    BrowserModule,
    FormsModule,
    BrowserAnimationsModule,
    MatIconModule,
    MatFormFieldModule,
    MatOptionModule,
    MatSelectModule,
    HttpClientModule,
    AppRoutingModule,
    MatSidenavModule,
    [RouterModule],
    MatListModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatCardModule,
    MatExpansionModule,
    MatButtonModule,     
    HttpClientModule,     
    MatSelectModule,
    MatDialogModule
  ],
  
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

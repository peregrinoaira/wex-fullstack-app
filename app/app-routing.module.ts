import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule,Routes } from '@angular/router';
import { ShopkeepComponent } from './components/shopkeep/shopkeep.component';
import { EditUserComponent } from './components/edit-user/edit-user.component';
import { CartComponent } from './components/cart/cart.component';
import { CheckoutComponent } from './components/checkout/checkout.component';
import { CouponsComponent } from './components/coupons/coupons.component';
import { EditCouponComponent } from './components/edit-coupon/edit-coupon.component';
import { EditProductComponent } from './components/edit-product/edit-product.component';
import { LoginComponent } from './components/login/login.component';
import { OrdersComponent } from './components/orders/orders.component';
import { ProductCategoryComponent } from './components/product-category/product-category.component';
import { ProductsComponent } from './components/products/products.component';

const routes: Routes =[
  { path:'product', component: ShopkeepComponent},
  { path: 'edit-user', component: EditUserComponent },
  { path: 'products', component: ProductsComponent },
  { path: 'product-category', component: ProductCategoryComponent },
  { path: 'coupons', component: CouponsComponent },
  { path: 'orders', component: OrdersComponent},
  { path: 'cart', component: CartComponent },
  { path: 'edit-product', component: EditProductComponent },
  { path: 'edit-coupon', component: EditCouponComponent },
  { path: 'checkout', component: CheckoutComponent },
  { path: 'login', component: LoginComponent },
  { path: '', component: ProductsComponent }
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    [RouterModule.forRoot(routes)],
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
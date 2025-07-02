import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from '../../Product';
import { OrderDetail } from 'app/OrderDetail';
import { User } from 'app/User';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  @Output() addToCartEmitter = new EventEmitter<any>();

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
  @Input() product: Product = {
    id: 0,
    productName: "default",
    productDescription: "default",
    productImage: "default",
    productPrice: 0,
    minimumPrice: 0,
    discontinued: false,
    onSaleId: 0,
    productCategoryId: 0
}
  
  productToShow = {
  customerView: true,
  customerViewCart: false,
  customerViewPriorOrders: false,
  shopKeeperView: false
  }

  numAddedToCart: number = 0;

 
  
  constructor() { }
  ngOnInit(): void {}

  sendAddToCartToParent(product: Product, quantity: number){
    const inCartItem = {
      singleProduct: product,
      quantity: quantity
    }
    this.addToCartEmitter.emit(inCartItem);
  }  

  // //this takes in the id of the product and updates the quantity in numAddedToCart
  // handleUpdateQuantity(productId: number, updatedQuantity: number): void {
  //   console.log("updated");
  //   //the foundItem is the item from the itemsInCart array
  //   const foundItem = this.itemsInCart.filter(item => item.id === productId);
  //   foundItem[0] = {...foundItem[0], productQuantity: updatedQuantity};
  // }

  // //this calls the delete product from cart method
  // handleDeleteFromCart(productToDeleteById: number):void {
  //   console.log("deleted");
  //   const foundItemIndex = this.itemsInCart.findIndex(item => item.id === productToDeleteById);
  //   this.itemsInCart.splice(foundItemIndex, 1);
  // }


}
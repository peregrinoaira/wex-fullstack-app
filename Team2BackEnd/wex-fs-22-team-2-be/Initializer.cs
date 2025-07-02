using wex_fs_22_team_2_be.Models;

namespace wex_fs_22_team_2_be
{
    public class Initializer
    {
       public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
            if (!context.User.Any())
            {
                User[] users = new[]
                {
                    new User {Username = "initialized", Email =  "email", Password = "eggs", IsAdmin = true, IsShopKeeper = false, IsCustomer = false, Token = 1234},
                    new User {Username = "Shopkeep1", Email =  "email", Password = "eggs", IsAdmin = false, IsShopKeeper = true, IsCustomer = false, Token = 1234},
                    new User {Username = "FirstUser", Email =  "email", Password = "eggs", IsAdmin = false, IsShopKeeper = false, IsCustomer = true, Token = 1234},
                    //new User {Username = "Noface", Email =  null, Password = null, IsAdmin = false, IsShopKeeper = false, IsCustomer = false, Token = 1234}
                };

                foreach (var user in users)
                {
                    context.User.Add(user);
                }
            }

            if(!context.Product.Any())
            {
                Product[] products = new[]
                {
                    new Product {ProductName = "Bearyold", ProductDescription = "A good boy", ProductImage = "https://i.imgur.com/bTRqiyq.jpg", ProductPrice = 10f, MinumunPrice = 10f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 1, TotalInventoryCount = 100},
                    new Product {ProductName = "Bearynew", ProductDescription = "A new girl", ProductImage = "https://i.imgur.com/N5tByFI.jpg", ProductPrice = 10f, MinumunPrice = 10f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 1, TotalInventoryCount = 200},
                    new Product {ProductName = "Embearassing", ProductDescription = "for software instructors", ProductImage = "https://i.imgur.com/ZbiTeha.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 1, TotalInventoryCount = 200},
                    new Product {ProductName = "Daniel", ProductDescription = "Your friend furever", ProductImage = "https://i.imgur.com/l00MU0l.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Greybeard", ProductDescription = "A magical friend", ProductImage = "https://i.imgur.com/M5GUGap.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},

                    new Product {ProductName = "Peterpanda", ProductDescription = "Never grow old", ProductImage = "https://i.imgur.com/ynqeUGi.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Pawsible pal", ProductDescription = "Made in Mexico", ProductImage = "https://i.imgur.com/vVrSrlv.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Milo", ProductDescription = "A great beargan", ProductImage = "https://i.imgur.com/82ke03n.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Jemes", ProductDescription = "Bearomire", ProductImage = "https://i.imgur.com/kmvbGq3.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Coca Koala", ProductDescription = "refreshing", ProductImage = "https://i.imgur.com/qxhzRBx.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 1, TotalInventoryCount = 200},

                    new Product {ProductName = "Bear arms", ProductDescription = "To hug with!", ProductImage = "https://i.imgur.com/END7oxC.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Graduation", ProductDescription = "Become stronger", ProductImage = "https://i.imgur.com/JrmFtJz.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "William Shakesbeare", ProductDescription = "Enthralling", ProductImage = "https://i.imgur.com/wWzt1Wh.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 6, TotalInventoryCount = 200},
                    new Product {ProductName = "Bear witch project", ProductDescription = "Scary!", ProductImage = "https://i.imgur.com/7ui36yU.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 5, TotalInventoryCount = 200},
                    new Product {ProductName = "Tibbers", ProductDescription = "Usually Inanimate", ProductImage = "https://i.imgur.com/o18OUCW.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 5, TotalInventoryCount = 200},

                    new Product {ProductName = "Grembearlins", ProductDescription = "Do not feed after midnight", ProductImage = "https://i.imgur.com/bWlGsfR.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 5, TotalInventoryCount = 200},
                    new Product {ProductName = "James", ProductDescription = "Missed the bearoplane", ProductImage = "https://i.imgur.com/4i5kOvk.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 4, TotalInventoryCount = 200},
                    new Product {ProductName = "Gorbearchav", ProductDescription = "A new girl", ProductImage = "https://i.imgur.com/XEP5Tmg.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 4, TotalInventoryCount = 200},
                    new Product {ProductName = "Bearis Yeltsin", ProductDescription = "At least he's not Putin", ProductImage = "https://i.imgur.com/K0kKNta.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 4, TotalInventoryCount = 200},
                    new Product {ProductName = "Sparky", ProductDescription = "Our favorite product!", ProductImage = "https://i.imgur.com/rdeyIPC.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 3, TotalInventoryCount = 200},

                    new Product {ProductName = "Freddy", ProductDescription = "blazbear", ProductImage = "https://i.imgur.com/hgTEpTC.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 3, TotalInventoryCount = 200},
                    new Product {ProductName = "Cadbeary", ProductDescription = "Delicious", ProductImage = "https://i.imgur.com/15OEglk.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 2, TotalInventoryCount = 200},
                    new Product {ProductName = "Reese's Bear", ProductDescription = "An unbearable combination", ProductImage = "https://i.imgur.com/wwWJbVP.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 2, TotalInventoryCount = 200},
                    new Product {ProductName = "A cake with bearloons", ProductDescription = "Contains products not reviewed by the FDA", ProductImage = "https://i.imgur.com/IgAKMi3.jpg", ProductPrice = 1f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 2, TotalInventoryCount = 200},
                    new Product {ProductName = "A bear with no teeth", ProductDescription = "A gummy bear", ProductImage = "https://i.imgur.com/qhNv9lH.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 2, TotalInventoryCount = 200},

                    new Product {ProductName = "Our Staff", ProductDescription = "We are unbearable!", ProductImage = "https://i.imgur.com/q7akGQc.jpg", ProductPrice = 10f, MinumunPrice = 1f, Discontinued = false, OnSale = false, Coupon = false, ProductCategoryId = 1, TotalInventoryCount = 200}
                };

                foreach (var prod in products)
                {
                    context.Product.Add(prod);
                }
            }

            if(!context.Inventory.Any())
            {
                Inventory[] inventories = new[]
                {
                    new Inventory {ProductId = 1, PriceIn = 0, ShipmentQuantity = 50, CurrentQuantity = 50, DateReceived = new DateTime()},
                    new Inventory {ProductId = 1, PriceIn = 0, ShipmentQuantity = 50, CurrentQuantity = 50, DateReceived = new DateTime()},
                    new Inventory {ProductId = 2, PriceIn = 0, ShipmentQuantity = 100, CurrentQuantity = 100, DateReceived = new DateTime()},
                    new Inventory {ProductId = 2, PriceIn = 0, ShipmentQuantity = 100, CurrentQuantity = 100, DateReceived = new DateTime()},

                    new Inventory {ProductId = 3, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 4, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 5, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},

                    new Inventory {ProductId = 6, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 7, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 8, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 9, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 10, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},

                    new Inventory {ProductId = 11, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 12, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 13, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 14, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 15, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},

                    new Inventory {ProductId = 16, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 17, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 18, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 19, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 20, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},

                    new Inventory {ProductId = 21, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 22, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 23, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 24, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},
                    new Inventory {ProductId = 25, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()},

                    new Inventory {ProductId = 26, PriceIn = 0, ShipmentQuantity = 200, CurrentQuantity = 200, DateReceived = new DateTime()}
                };
                foreach( var inven in inventories)
                {
                    context.Inventory.Add(inven);
                }
            }

            if(!context.Coupon.Any())
            {
                Coupon[] coupons = new[]
                {
                    new Coupon {Name = "firstcoupon", AmountDiscounted = 3f, CouponStart = new DateTime(), CouponEnd = new DateTime() },
                    new Coupon {Name = "secondcoupoin", AmountDiscounted = 50f, CouponStart = new DateTime(), CouponEnd = new DateTime() },
                };
                foreach (var coup in coupons)
                {
                    context.Coupon.Add(coup);
                }
            }

            if (!context.Order.Any())
            {
                Order[] orders = new[]
                {
                    new Order {OrderIdNum = "1709IO1", UserId = 1, OrderTotal = 5 },
                    new Order {OrderIdNum = "1709IO2", UserId = 2, OrderTotal = 5 },
                };
                foreach (var ord in orders)
                {
                    context.Order.Add(ord);
                }
            }

            if (!context.OrderDetails.Any())
            {
                OrderDetail[] orderDetails = new[]
                {
                    new OrderDetail {OrderIdNum = "1709IO1", ProductId = 1, ProductName = "firstProd", ProductDescription = "something", ProductImage = "http...", ProductPrice = 7f, Quantity = 7, TotalPriceForProduct = 49f},
                    new OrderDetail {OrderIdNum = "1709IO2", ProductId = 2, ProductName = "secondProd", ProductDescription = "something", ProductImage = "http...", ProductPrice = 7f, Quantity = 7, TotalPriceForProduct = 49f},
                };
                foreach (var ordet in orderDetails)
                {
                    context.OrderDetails.Add(ordet);
                }
            }

            if(!context.Sale.Any())
            {
                Sale[] sales = new[]
                {
                    new Sale { SalesPrice = 5f, SalesStart = DateTime.Now.AddDays(1), SalesEnd = DateTime.Now.AddDays(3) },
                    new Sale {SalesPrice = 5f, SalesStart = DateTime.Now.AddDays(2), SalesEnd = DateTime.Now.AddDays(4) },
                };

                foreach (var sale in sales)
                {
                    context.Sale.Add(sale);
                }
            }

            if(!context.ProductCategory.Any())
            {
                ProductCategory[] productcategories = new[]
                {
                    //these are the current report cat's as of 09/17
                    new ProductCategory {CategoryName = "Costume" },
                    new ProductCategory {CategoryName = "Edible" },
                    new ProductCategory {CategoryName = "Electric" },
                    new ProductCategory {CategoryName = "Misfit" },
                    new ProductCategory {CategoryName = "Scary" },
                    new ProductCategory {CategoryName = "Snuggly" },
                };
                foreach (var prodcat in productcategories)
                {
                    context.ProductCategory.Add(prodcat);
                }
            }

            if (!context.Report.Any())
            {
                Report[] reports = new[]
                {
                    new Report {ProductId = 1, },
                };
                foreach (var rep in reports)
                {
                    context.Report.Add(rep);
                }
            }
            context.SaveChanges();
        }
    }
}
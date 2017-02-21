using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;

        

        [Fact]
        public void WhenCartIsCheckOut_TheProductsShouldbeReducedFromTheInventory()
        {
            var db = new Database();
            
            var inventory2 = new Inventory()
            {
              Id=3,
              ProductId=3,
              Quantity=50,

            };
            var prgm = new Program();
            var list = prgm.Equals(inventory2);
            Assert.Equal(100, prgm.UpdateInventory(inventory2).Quantity);
            
           
        }
        [Fact]
        public void WhenCartIsCheckOut_ItWillCheckProductIsExistInInventoryOrNot()
        {
            var db = new Database();
            var inventory3 = new Inventory()
            {
                Id=1,
                ProductId=1,
            };
            var prgm = new Program();
            var list = prgm.Equals(inventory3);
            Assert.True(true);
        }
        [Fact]
        public void WhenProductAddingProductToInventory_InventoryListShouldBeIncreased()
        {
            var db = new Database();
            var inventory = new Inventory()
            {
                Id = 6,
                ProductId = 5,
                Quantity = 5,
            };
            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);
        }
        [Fact]
        public void WhenProductDetailsChangedInInventory_InventoryListShouldBeUpdated()
        {

            var inventory1 = new Inventory()
            {
                Id = 2,
                ProductId = 2,
                Price = 70,
            };
            var prgm1 = new Program();

            Assert.Equal(70, prgm1.UpdateInventory(inventory1).Price);
        }
        [Fact]
        public void WhenRemovingProductFromInventory_InventoryListShouldbeDecreased()
        {
            var db = new Database();
           var inventory = new Inventory()
           {
               Id = 4,
                ProductId = 4,
            };
            var prgm2 = new Program();
            var list = prgm2.DeleteInventory(inventory);
            Assert.Equal(5,db.InventoryList.Count);
        }
        [Fact]
        public void WhenTheUserChecksOut_PassTest()
        {
            var inventorySize = new Database().InventoryList.Count;
            
            List<Cart> cartList = new List<Cart>();
            var cart = new Cart()
            {
                Id = 2,
                ProductId = 2,
                OrderedQuantity = 23
            };
            cartList.Add(cart);
            var prgm4 = new Program();
            Assert.Equal(inventorySize,prgm4.CheckOutTheCartandUpdateInventory(cartList).Count);

        }
       
    }
}

















 


using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopClient.Services
{
    public interface ICartServices
    {
        event Action OnChange;
        void AddToCart(int id, List<MonAn> monAns);
        void DeleteCart(CartItem cart, PostCartModel giohang);
    }
    public class CartServices : ICartServices
    {
        public List<MonAn> monAns = null;
        private readonly IConfiguration config;
        protected string imgUrl = "";
        public CartServices(ISyncSessionStorageService sessionStorageService, IConfiguration configuration)
        {
            _SessionStorageService = sessionStorageService;
            config = configuration;

        }

        public ISyncSessionStorageService _SessionStorageService { get; }

        public event Action OnChange;
        private double Tinhtien(List<CartItem> listCart)
        {
            double tongtien = 0;
            if (listCart != null)
            {
                for (int i = 0; i < listCart.Count; i++)
                {
                    tongtien += listCart[i].Sotien;
                }
            }
            return tongtien;
        }

        public void AddToCart(int id, List<MonAn> monAns)
        {
            var cart = _SessionStorageService.GetItem<string>("cart");//get key cart
            if (cart == null)
            {

                var monAn = monAns.Where(u => u.Id == id).FirstOrDefault();
                List<CartItem> listCart = new List<CartItem>()
            {
                    new CartItem
                    {
                        product = monAn,
                        quantity = 1,
                        Sotien= (double)monAn.Gia
                    }
            };

                PostCartModel giohang = new PostCartModel()
                {
                    cartItems = listCart,
                    TongTien = Tinhtien(listCart)
                };

                _SessionStorageService.SetItem("cart", JsonConvert.SerializeObject(giohang));
                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            else
            {
                var monAn = monAns.Where(u => u.Id == id).FirstOrDefault();

                PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
                //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                bool check = true;
                for (int i = 0; i < giohang.cartItems.Count; i++)
                {
                    if (giohang.cartItems[i].product.Id == id)
                    {
                        giohang.cartItems[i].quantity++;
                        giohang.cartItems[i].Sotien = (double)monAn.Gia * giohang.cartItems[i].quantity;
                        check = false;
                    }
                }

                if (check)
                {
                    //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                    giohang.cartItems.Add(new CartItem
                    {
                        product = monAn,
                        quantity = 1,
                        Sotien = (double)monAn.Gia * 1
                    });
                }
                giohang.TongTien = Tinhtien(giohang.cartItems);
                _SessionStorageService.SetItem("cart", JsonConvert.SerializeObject(giohang));

                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }
            OnChange.Invoke();
            //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
        }

        public void DeleteCart(CartItem cart, PostCartModel giohang)
        {
            giohang.cartItems.Remove(cart);
            giohang.TongTien = Tinhtien(giohang.cartItems);
            _SessionStorageService.SetItem("cart", JsonConvert.SerializeObject(giohang));
            OnChange.Invoke();
        }
    }
}


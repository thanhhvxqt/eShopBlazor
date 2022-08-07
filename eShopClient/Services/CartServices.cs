using Blazored.SessionStorage;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace eShopClient.Services
{
    public interface ICartService
    {
        void AddSingle(int id, List<MonAn> monan);
        void AddMultiple(int id, int soluong, MonAn monan);
    }
    public class CartServices : ICartService
    {
        private readonly ISyncSessionStorageService _syncSessionStorageService;
        public string CARTKEY = "cart";
        public CartServices(ISyncSessionStorageService syncSessionStorageService)
        {
            this._syncSessionStorageService = syncSessionStorageService;
        }

        public void AddSingle(int id, List<MonAn> monan)
        {
            var cart = GetItemInCart();//get key cart
            var monAn = CheckFoodExist(id, monan);
            if (cart == null)
            {


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

                SetItemToCart(giohang);
                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            else
            {
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
                        break;
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

                SetItemToCart(giohang);
                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }
        }
        public void SetItemToCart(PostCartModel giohang)
        {
            _syncSessionStorageService.SetItem(CARTKEY, JsonConvert.SerializeObject(giohang));
        }
        public string GetItemInCart()
        {
            return _syncSessionStorageService.GetItem<string>(CARTKEY);
        }
        public MonAn CheckFoodExist(int id, List<MonAn> monAns)
        {
            return monAns.Where(u => u.Id == id).FirstOrDefault();
        }
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

        public void AddMultiple(int id, int soluong, MonAn monan)
        {
            int sl = 1;
            //_cartSvc.AddToCart(id, monAns);
            if (soluong > 0)
            {
                sl = soluong;
            }

            //var cart = HttpContext.Session.GetString("cart");//get key cart
            var cart = _syncSessionStorageService.GetItem<string>("cart");//get key cart
            if (cart == null)
            {

                //var monAn = monAns.Where(u=>u.Id==id).FirstOrDefault();
                List<CartItem> listCart = new List<CartItem>()
            {
                    new CartItem
                    {
                        product = monan,
                        quantity = sl,
                        Sotien= (double)monan.Gia
                    }
            };

                PostCartModel giohang = new PostCartModel()
                {
                    cartItems = listCart,
                    TongTien = Tinhtien(listCart)
                };

                _syncSessionStorageService.SetItem("cart", JsonConvert.SerializeObject(giohang));
                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));
            }
            else
            {
                //var monAn = monAns.Where(u => u.Id == id).FirstOrDefault();

                PostCartModel giohang = JsonConvert.DeserializeObject<PostCartModel>(cart);
                //List <ViewCart> dataCart = JsonConvert.DeserializeObject<List<ViewCart>>(cart);
                bool check = true;
                for (int i = 0; i < giohang.cartItems.Count; i++)
                {
                    if (giohang.cartItems[i].product.Id == id)
                    {
                        giohang.cartItems[i].quantity += sl;
                        giohang.cartItems[i].Sotien = (double)monan.Gia * giohang.cartItems[i].quantity;
                        check = false;
                    }
                }

                if (check)
                {
                    //var monAn = monAns.Where(u => u.MonAnID == id).FirstOrDefault();
                    giohang.cartItems.Add(new CartItem
                    {
                        product = monan,
                        quantity = sl,
                        Sotien = (double)monan.Gia * 1
                    });
                }
                giohang.TongTien = Tinhtien(giohang.cartItems);
                _syncSessionStorageService.SetItem("cart", JsonConvert.SerializeObject(giohang));

                //HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
            }
        }
    }
}

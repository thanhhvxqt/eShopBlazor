
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;


    public class CartService
    {
        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";
        //private readonly IHttpContextAccessor _context;
        private readonly ISyncSessionStorageService _syncSessionStorageService;

        public CartService(IHttpContextAccessor context, ISyncSessionStorageService syncSessionStorageService)
        {
            //_context = context;
            this._syncSessionStorageService = syncSessionStorageService;
            _httpContext = context.HttpContext;
        }

        private readonly HttpContext _httpContext;

        // Lấy cart từ Session (danh sách CartItem)
        public List<CartItem> GetCartItems()
        {

            var session = _httpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        public void ClearCart()
        {
            var session = _httpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        public void SaveCartSession(List<CartItem> ls)
        {
            var session = _httpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
    }


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopClient.Paging;
using eShopControl.Paging;
using eShopShare.Models.Paging;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

public interface IMonAnSvc
{
    List<MonAn> GetMonAnAll();
    Task<PagedList<MonAn>> GetMonAnAllClient(ProductParameters productParameters);
    MonAn GetMonAn(int id);
    Task<int> AddMonAn(MonAn monAn);
    Task<int> EditMonAn(int id, MonAn monAn);
    Task<List<MonAn>> Search(string text);
}
public class MonAnSvc : IMonAnSvc

{

    protected DataContext _context;
    public MonAnSvc(DataContext context)
    {
        _context = context;
    }

    public async Task<int> AddMonAn(MonAn monAn)
    {
        int ret = 0;
        try
        {
            await _context.AddAsync(monAn);
            await _context.SaveChangesAsync();
            ret = monAn.Id;
        }
        catch
        {
            ret = 0;
        }
        return ret;
    }

    public async Task<int> EditMonAn(int id, MonAn monAn)
    {
        int ret = 0;
        try
        {
            var model = _context.Update(monAn);
            model.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            ret = monAn.Id;
        }
        catch
        {
            ret = 0;
        }
        return ret;
    }

    public MonAn GetMonAn(int id)
    {
        var monan = _context.MonAns.Include(x => x.Photos).Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
        monan.Views++;
        _context.SaveChanges();
        return  monan;
    }

    public List<MonAn> GetMonAnAll()
    {
        return _context.MonAns.Include(x => x.Photos).Include(x=>x.Category).ToList();
    }

    public async Task<PagedList<MonAn>> GetMonAnAllClient(ProductParameters productParameters)
    {
        var products = await _context.MonAns.Include(x => x.Photos).Include(x => x.Category).ToListAsync();
        return PagedList<MonAn>
        .ToPagedList(products, productParameters.PageNumber, productParameters.PageSize);
    }

    public async Task<List<MonAn>> Search(string text)
    {
        return await _context.MonAns.Where(m => m.Name.Contains(text) || m.MoTa.Contains(text)).ToListAsync();
    }
}


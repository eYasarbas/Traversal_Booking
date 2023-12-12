using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfGuideDal : GenericRepository<Guide>, IGuideDal
{
    private readonly Context context = new();


    public void ChangeToTrueByGuide(int id)
    {
        var values = context.Guides.Find(id);
        if (values != null)
        {
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }

    public void ChangeToFalseByGuide(int id)
    {
        var values = context.Guides.Find(id);
        if (values != null)
        {
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }
    }

    public async Task<Guide> GuidesstatuChangeToTrue(int id)
    {
        var model = await context.Guides.FindAsync(id);
        if (model.Status)
            model.Status = false;
        else
            model.Status = true;
        context.SaveChangesAsync();
        return model;
    }
}
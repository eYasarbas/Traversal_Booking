using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container;

public class BuilderExtensions
{
    public static void ContainerDependencies(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ICommentService, CommentManager>();
        builder.Services.AddScoped<ICommentDal, EfCommentDal>();

        builder.Services.AddScoped<IAppUserService, AppUserManager>();
        builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

        builder.Services.AddScoped<IDestinationService, DestinationManager>();
        builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();

        builder.Services.AddScoped<IReservationService, ReservationManager>();
        builder.Services.AddScoped<IReservationDal, EfReservationDal>();

        builder.Services.AddScoped<IGuideService, GuideManager>();
        builder.Services.AddScoped<IGuideDal, EfGuideDal>();

        builder.Services.AddScoped<IExcelService, ExcelManager>();

        builder.Services.AddScoped<IPdfService, IPdfManager>();
    }
}
﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete;

public class GuideManager : IGuideService
{
    private IGuideDal _guideDal;

    public GuideManager(IGuideDal guideDal)
    {
        _guideDal = guideDal;
    }

    public void TAdd(Guide item)
    {
        throw new NotImplementedException();
    }

    public void TDelete(Guide item)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(Guide item)
    {
        throw new NotImplementedException();
    }

    public List<Guide> TGetList()
    {
        return _guideDal.GetList();
    }

    public Guide TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Guide> GetByFilter(Expression<Func<Guide, bool>> filter)
    {
        throw new NotImplementedException();
    }
}
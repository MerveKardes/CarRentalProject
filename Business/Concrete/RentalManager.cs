using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        //[ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.CarRentalInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult();

            //var result = _rentalDal.Get(p => p.CarId == rental.CarId && rental.ReturnDate == null);
            //if (result!=null)
            //{
            //    return new ErrorResult(Messages.CarRentalInvalid);

            //}
            //_rentalDal.Add(rental);
            //return new SuccessResult(Messages.RentalAdded);

            //var result = _rentalDal.Get(c => c.CarId == rental.CarId);

            //if (result.ReturnDate != null)
            //{
            //    _rentalDal.Add(rental);
            //    return new SuccessResult(Messages.RentalAdded);
            //}

            //return new ErrorResult(Messages.CarRentalInvalid);

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            var result = _rentalDal.Get(p => p.Id == rentalId);
            if (result != null)
            {
                return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == rentalId));
            }
            else
            {
                return new ErrorDataResult<Rental>(_rentalDal.Get(p => p.Id == rentalId));
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}

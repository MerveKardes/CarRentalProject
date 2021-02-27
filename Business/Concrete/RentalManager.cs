using Business.Abstract;
using Business.Constants;
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

        public IResult Add(int carId)
        {
            //if (rental.ReturnDate == null)
            //{
            //    return new ErrorResult(Messages.CarRentalInvalid);
            //} 
            //_rentalDal.Add(rental);
            //return new SuccessResult();

            var result = _rentalDal.Get(p => p.CarId == carId);
            if (result != null)
            {
                return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.CarId == carId),Messages.Added);
            }
            else
            {
                return new ErrorDataResult<Rental>(_rentalDal.Get(p => p.CarId == carId),Messages.AddedInvalid);
            }

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

        public IDataResult<Rental> GetById(int carId)
        {
            var result = _rentalDal.Get(p => p.CarId == carId);
            if (result != null)
            {
                return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.CarId == carId));
            }
            else
            {
                return new ErrorDataResult<Rental>(_rentalDal.Get(p => p.CarId == carId));
            }
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}

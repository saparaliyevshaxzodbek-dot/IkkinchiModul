using System;
using System.Collections.Generic;
using System.Text;

namespace _2chiDarsUyvaziyfasi;

public class CarServise
{
    public List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        car.DateTime = DateTime.UtcNow;

        return car.CarId;
    }

    public Guid DeleteCar(Guid carId)
    {
        var car = Cars.FirstOrDefault(c => c.CarId == carId);
        if(car != null)
        {
            Cars.Remove(car);
            return carId;
        }
        return Guid.Empty; 
    }

    public List<Car> GetAllCars()
    {
        return Cars; 
    }

    public void UpdateCar(Car updateCar)
    {
        var existingCar = Cars.FirstOrDefault(c => c.CarId == updateCar.CarId);
        if(existingCar != null)
        {
            existingCar.CarName = updateCar.CarName;
            existingCar.Year = updateCar.Year;
            existingCar.Color = updateCar.Color;
            existingCar.DateTime = DateTime.Now;

        }
    }

    public Car GetCar(Guid carId)
    {
        var car = Cars.FirstOrDefault(c => c.CarId == carId);

        return car;
    }


}

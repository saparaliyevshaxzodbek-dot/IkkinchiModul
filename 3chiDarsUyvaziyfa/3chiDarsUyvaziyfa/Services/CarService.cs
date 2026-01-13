using _3chiDarsUyvaziyfa.Models;

namespace _3chiDarsUyvaziyfa.Services;

public class CarService
{
    List<Car> Cars = new List<Car>();

    public Guid AddCar(Car car)
    {
        car.CarId = Guid.NewGuid();
        Cars.Add(car);
        return car.CarId;
    }

    public Car? GetCArById(Guid carId)
    {
        foreach (Car car in Cars)
        {
            if (car.CarId == carId)
            {
                return car;
            }
        }
        return null;
    }

    public bool DeleteCar(Guid carId)
    {
        foreach (var car in Cars)
        {
            if (car.CarId == carId)
            {
                Cars.Remove(car);
                return true;
            }
        }
        return false;
    }

    public List<Car> GetAllCars()
    {
        return Cars;
    }

    public bool UpdateCar(Guid carId, Car newcar)
    {
        var car = GetCArById(carId);

        if (car == null)
        {
            return false;
        }

        car.Year = newcar.Year;
        car.Name = newcar.Name;
        car.Price = newcar.Price;
        car.Color = newcar.Color;

        return true;


    }
}

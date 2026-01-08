namespace _2chiDarsUyvaziyfasi;

internal class Program
{
    static void Main(string[] args)
    {

        //1-misol
        //CarServise carServise = new CarServise();

        //    Car car1 = new Car
        //    {
        //        CarName = "Matiz",
        //        Color = "blue",
        //        Year = 2001,
        //        Model = "Chevrolet"

        //    };

        //var carId =  carServise.AddCar(car1);

        //carServise.DeleteCar(carId);

        //2-misol

        SchoolService schoolService = new SchoolService();

        School school = new School()
        {
            Capasty = 450,
            Name = "School",
            SchoolNamber = 16,
            Description = "16 - maktab"
        };

         var schoolId =  schoolService.AddSchool(school);

        schoolService.DeleteSchool(schoolId);


    }
}

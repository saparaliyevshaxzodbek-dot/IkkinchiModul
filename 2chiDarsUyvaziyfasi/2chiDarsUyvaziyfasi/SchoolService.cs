using System;
using System.Collections.Generic;
using System.Text;

namespace _2chiDarsUyvaziyfasi;

public class SchoolService
{
    public List<School> Schools = new List<School>();

    public Guid AddSchool (School school)
    {
        school.SchoolId = Guid.NewGuid();
        school.DateTime = DateTime.UtcNow;
        Schools.Add(school);
        return school.SchoolId;
    }

    public Guid DeleteSchool(Guid schoolId)
    {
        var school = Schools.FirstOrDefault(s =>  s.SchoolId == schoolId);

        if(school == null)
        {
            Schools.Remove(school);
            return schoolId;
        }
        return Guid.Empty;
    }

    public List<School> GetAllSchools()
    {
        return Schools;
    }

    public void UpdateSchool(School UpdateSchool)
    {
        var existingSchool = Schools.FirstOrDefault(s => s.SchoolId == UpdateSchool.SchoolId);
        if(existingSchool != null)
        {
            existingSchool.SchoolNamber = UpdateSchool.SchoolNamber;
            existingSchool.Name = UpdateSchool.Name;
            existingSchool.Capasty = UpdateSchool.Capasty;
            existingSchool.Description = UpdateSchool.Description;
            

        }
    }

    public School GetById(Guid schoolId)
    {
        return Schools.FirstOrDefault(s => s.SchoolId == schoolId);
    }
}

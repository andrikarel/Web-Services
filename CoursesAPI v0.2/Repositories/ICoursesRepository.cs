using System.Collections.Generic;
using CoursesAPI.Models.DTOModels;

namespace CoursesAPI.Repositories {
    public interface ICoursesRepository {
        IEnumerable<CoursesDTO> GetCourses(string semester);
        CoursesDTO GetCourseByID(int ID);
    }
}
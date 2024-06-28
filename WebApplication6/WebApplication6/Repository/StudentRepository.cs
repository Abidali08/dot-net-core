using WebApplication6.Models;

namespace WebApplication6.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.STDID == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>()
            {
                new StudentModel() {STDID = 1,Name="Abid",Gender="Male",Semester="3"},
                new StudentModel() {STDID = 2,Name="Adil",Gender="Male",Semester="4"},
                new StudentModel() {STDID = 3,Name="Farheen",Gender="Female",Semester="5"},
                new StudentModel() {STDID = 4,Name="Rayyan",Gender="Male",Semester="3"},
                new StudentModel() {STDID = 5,Name="Aysha",Gender="Female",Semester="2"},
            };
        }
    }
}

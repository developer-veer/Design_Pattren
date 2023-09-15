namespace Aggregation
{
    public class EducationalInstitute
    {
        public string? name;
        public int totalStudnets;
    }


    public class Student
    {
        EducationalInstitute objInstitute;
        public Student(EducationalInstitute obj)
        {

            this.objInstitute = obj;

        }



    }

    public class Factory
    {
        public static EducationalInstitute EduObj()
        {
            return new EducationalInstitute();
        }
    }
}
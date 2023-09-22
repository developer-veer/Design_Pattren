namespace Inheritance
{
  class Person
  {
    protected string? name;
    protected int age;

    protected string? address;

  }

  class Man{

  }

  class Student : Person
  {

    public Student(string name, string address, string program, int age)
    {

      this.name = name;
      this.age = age;
      this.program = program;
      this.address = address;
      

    }
    public string? program;

    public void Studying()
    {
      Console.WriteLine("My Name Is : " + this.name + ", Studying " + this.program);
    }


  }

}
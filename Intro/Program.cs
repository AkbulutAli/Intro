using Intro;

Category category1 = new Category();
category1.Id = 1;
category1.Name = "Programlama";

Instructor[] instructors = new Instructor[]
{
    new Instructor()
    {
        Id = 1,
        Name = "Engin Demiroğ"
    },
    new Instructor()
    {
        Id = 2,
        Name = "Halit Enes Kalaycı"
    }
};

Course[] courses = new Course[]
{
    new Course()
    {
        Id = 1,
        CategoryId = 1,
        Name = "Yazılım Geliştici Yetiştirme Kampı (JavaScript)",
        Description = "1,5 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
        Price = 0,
        InstructorId= 1,
        Category = category1,
        Instructor = instructors[0],
    },
      new Course()
    {
        Id = 2,
        CategoryId = 1,
        Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
        Description = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.",
        Price = 0,
        InstructorId= 2,
        Category = category1,
        Instructor = instructors[1],
    }
};

foreach (var item in courses)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Category.Name);
    Console.WriteLine(item.Name);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.Price);
    Console.WriteLine(item.Instructor.Name);
    Console.WriteLine("------------------------------------------------------------------------------------------------------");

}



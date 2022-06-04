using console_linq_ef;
//First data
/* 
using(var context = new ApplicationDBContext())
{
    var person1 = new Person() { Name="Randall"};
    var person2 = new Person() { Name = "Luis" };

    context.AddRange(person1, person2);
    context.SaveChanges();
}
*/

using (var context = new ApplicationDBContext())
{
    var people = context.People.ToList();
    var peopleName = context.People.Select(x => x.Name).ToList();//EF convert this to SELECT Name FROM PEOPLE;
    var randall = context.People.FirstOrDefault(p => p.Name == "Randall");
    var jose = context.People.Where(p => p.Name == "Jose").ToList();
    var jose2 = context.People.FirstOrDefault(p => p.Name == "Jose");

    //Query syntax
    var randall_2 = (from p in context.People
                    where p.Name == "Randall"
                    select p).FirstOrDefault();

    //Not all LINQ Expressions are valid in EF, for example Chunk doesn't exists
    //var segments = context.People.Chunk(2).ToList();
}

Console.WriteLine("Hello, World!");

using Sketches;

Person person5 = new Person("Viana", 15);
Person person1 = new Person("Rafael", 25);
Person person3 = new Person("Raquel", 28);
Person person2 = new Person("Joana", 30);
Person person4 = new Person("Marcelo", 43);

List<Person> persons =
[
    person1,
    person2,
    person3,
    person4,
    person5
];

IEnumerable<Person> query = 
    from person in persons 
    where person.Age < 30 
    select person; 

foreach (Person person in query)
{
    Console.WriteLine(person.Name);
}

var query2 = persons.Where(person => person.Age < 30);

foreach (Person person in query2)
{
    Console.WriteLine(person.Name);
}
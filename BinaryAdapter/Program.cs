using BinaryAdapter;

string filePath = "people.txt"; 
IPersonRepository personRepository = new PersonBinaryRepository(filePath);

//Agregar algunas personas 

personRepository.Add(new Person { Name = "Efrain", Age = 18, Height = 1.76 });
personRepository.Add(new Person { Name = "Octavio", Age = 18, Height = 1.78 });
personRepository.Add(new Person { Name = "Sami", Age = 18, Height = 1.34 });

Console.WriteLine($"Datos de personas guardadas en {filePath}");

foreach (Person person in personRepository.GetAll())
    Console.WriteLine($"Id: {person.Id}, {person.Name}, {person.Age}, {person.Height}");
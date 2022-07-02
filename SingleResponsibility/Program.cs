using SingleResponsibility; // bu namespace içerisindeki sınıflara erişmek için


// Single Reponsibilty Prencible
// O
// L
// I
// D


Person p = new Person();
p.Name = "Ekrem";
p.Surname = "Yıldırım";

Person p2 = new Person();
p2.Name = "Onur";
p2.Surname = "Derman";

PersonOperation operation = new PersonOperation();
operation.Add(p);
operation.Add(p2);

operation.ShowPersons();

Console.ReadKey();
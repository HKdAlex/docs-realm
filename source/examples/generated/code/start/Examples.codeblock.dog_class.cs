public class Dog : RealmObject
{
    [Required]
    public string Name { get; set; }

    public int Age { get; set; }
    public string Breed { get; set; }
    public IList<Person> Owners { get; }

    public Dog() { }
}

public class Person : RealmObject
{
    [Required]
    public string Name { get; set; }
    //etc...
}
/*  To add items to the IList<T>:
 
    var dog = newDog();
    dog.Owners.Add("Caleb");
    
 */
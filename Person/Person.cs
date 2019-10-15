using System;
public class Person {
    public string firstName;
    public string lastName;
    public DateTime Age;

    // Creates Person Objects and stores them in the personArray
    public Person[] createPersons(int numPersons) {
        Person[] personArray = new Person[numPersons];
        for(int i = 0; i < numPersons; i++) {
            personArray[i] = new Person();
        }

        return personArray;
    }

    // Sets the Person Objects values
    public void setPersonValues(Person[] personArray) {
        Person person0 = personArray[0];
        person0.firstName = "Daniel";
        person0.lastName = "Wagner";
        person0.Age = new DateTime(1980, 9, 9);
        Person person1 = personArray[1];
        person1.firstName = "Gustav";
        person1.lastName = "Gans";
        person1.Age = new DateTime(1989, 9, 9);
        Person person2 = personArray[2];
        person2.firstName = "Chuck";
        person2.lastName = "Norris";
        person2.Age = new DateTime(1970, 9, 9);
        Person person3 = personArray[3];
        person3.firstName = "Micheal";
        person3.lastName = "Jackson";
        person3.Age = new DateTime(2000, 9, 9);
        Person person4 = personArray[4];
        person4.firstName = "Osama";
        person4.lastName = "Binladen";
        person4.Age = new DateTime(2001, 9, 11);
    }

    // Calculates the difference between the current date and the persons ages
    public void checkForAge(Person[] personArray) {
        DateTime currentDate = DateTime.Now;
        DateTime personAge;
        TimeSpan differenceGes;
        int years;
        for(int i = 0; i < personArray.Length; i++) {
            personAge = personArray[i].Age;
            differenceGes = currentDate - personAge;
            years = differenceGes.Days/365;
            if(years > 20) {
                Console.WriteLine(personArray[i].firstName + " " + personArray[i].lastName + " is older than 20 years");
            } else {
                Console.WriteLine(personArray[i].firstName + " " + personArray[i].lastName + " is younger than 20 years");
            }
        }
    
    }
 
    public static void Main(string[] args) {
        Person persons = new Person();
        Person[] personArray = persons.createPersons(5);
        persons.setPersonValues(personArray);
        persons.checkForAge(personArray);
    }
}
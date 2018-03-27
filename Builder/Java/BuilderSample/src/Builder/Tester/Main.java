package Builder.Tester;

import Builder.Core.PersonBuilder;
import Builder.Core.Gender;
import Builder.Core.Person;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		PersonBuilder builder = new PersonBuilder();
		
		Person person = 
		builder
		.Id(1)
		.FirstName("John")
		.LastName("Hanbury")
		.Age(24)
		.Gender(Gender.Male)
		.Weight(94.5)
		.Height(183.1)
		.Build();
		
		System.out.println("----------------- Person -------------------");
		System.out.println("Id: " + person.get_id());
		System.out.println("First Name: " + person.get_firstName());
		System.out.println("Last Name: " + person.get_lastName());
		System.out.println("Age: " + person.get_age());
		System.out.println("Weight: " + person.get_weight());
		System.out.println("Height: " + person.get_height());
		System.out.println("Gender: " + person.get_gender().toString());
	}

}

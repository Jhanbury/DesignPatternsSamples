package Builder.Core;

import java.util.Objects;
import java.util.function.Supplier;

public class PersonBuilder {
	//private final Supplier<? extends Person> ctor;
	private Person _person;
	
	
	//public PersonBuilder(Supplier<? extends Person> ctor) {
	  //  this.ctor = Objects.requireNonNull(ctor);
	    //this._person = ((Person)ctor.get());
	  //}
	public PersonBuilder() {
		this._person = new Person();
	}
	
	public PersonBuilder Id(int id) {
		this._person.set_id(id);
		return this;
	}
	
	public PersonBuilder FirstName(String firstName) {
		this._person.set_firstName(firstName);
		return this;
	}
	
	public PersonBuilder LastName(String lastName) {
		this._person.set_lastName(lastName);
		return this;
	}
	public PersonBuilder Age(int age) {
		this._person.set_age(age);
		return this;
	}
	public PersonBuilder Weight(double weight) {
		this._person.set_weight(weight);
		return this;
	}
	public PersonBuilder Height(double height) {
		this._person.set_height(height);
		return this;
	}
	public PersonBuilder Gender(Gender gender) {
		this._person.set_gender(gender);
		return this;
	}

	public Person Build() {
		// TODO Auto-generated method stub
		return this._person;
	}

}

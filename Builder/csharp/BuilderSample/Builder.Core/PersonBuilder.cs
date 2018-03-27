namespace Builder.Core
{
    public class PersonBuilder : IBuilder<Person>
    {
        private Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public PersonBuilder Id(int id)
        {
            this._person.Id = id;
            return this;
        }
        public PersonBuilder FirstName(string firstName)
        {
            this._person.FirstName = firstName;
            return this;
        }public PersonBuilder LastName(string lastName)
        {
            this._person.LastName = lastName;
            return this;
        }public PersonBuilder Age(int age)
        {
            this._person.Age = age;
            return this;
        }public PersonBuilder Weight(double weight)
        {
            this._person.Weight = weight;
            return this;
        }public PersonBuilder Height(double height)
        {
            this._person.Height = height;
            return this;
        }public PersonBuilder Gender(Gender gender)
        {
            this._person.Gender = gender;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}
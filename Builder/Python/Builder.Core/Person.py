class Person(object):
    def __init__(self, *args):
        self.Id = None;
        self.FirstName = None;
        self.LastName = None;
        self.Age = None;
        self.Height = None;
        self.Weight = None;
        self.Gender = None;
        super(Person, self).__init__(*args)

    def __str__(self):
        return "Id: {}\nFirst Name: {}\nLast Name: {}\nAge: {}\nHeight: {}\nWeight: {}\nGender: {}".format(str(self.Id),str(self.FirstName), str(self.LastName), str(self.Age), str(self.Height), str(self.Weight), str(self.Gender))
    
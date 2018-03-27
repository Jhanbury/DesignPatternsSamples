from Builder import Builder
from Gender import Gender
class ManBuilder(Builder): 
        

    def build_Id(self, id):
        self.person.Id = id

    def build_FirstName(self,name):
        self.person.FirstName = name

    def build_LastName(self, name):
        self.person.LastName = name

    def build_age(self, age):
        self.person.Age = age

    def build_Weight(self,weight):
        self.person.Weight = weight

    def build_Height(self,height):
        self.person.Height = height

    def build_Gender(self):
        self.person.Gender = Gender.Male
        return self.person
        
        

        
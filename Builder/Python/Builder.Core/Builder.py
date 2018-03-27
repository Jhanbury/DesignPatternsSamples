from Person import Person
class Builder(object):
    def __init__(self):
        self.person = Person()
        
    def new_Person(self):
        self.person = Person()   

    
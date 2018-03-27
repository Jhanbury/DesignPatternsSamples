from ManBuilder import ManBuilder
from WomanBuilder import WomanBuilder
builder = ManBuilder()
builder2 = WomanBuilder()
print("------Build Man--------")
builder.build_Id(1)
builder.build_age(25)
builder.build_FirstName("John")
builder.build_LastName("Doe")
builder.build_Height(183.0)
builder.build_Weight(89.5)
builder.build_Gender()

man = builder.person
print(man)

print("------Build Woman--------")

builder2.build_Id(2)
builder2.build_age(25)
builder2.build_FirstName("Jane")
builder2.build_LastName("Doe")
builder2.build_Height(175.0)
builder2.build_Weight(70.5)
builder2.build_Gender()

woman = builder2.person
print(woman)



    



fullName = input("Please, enter your full name:")

separatedName = fullName.split()
sep = '.'
l = []
for name in separatedName:
    if (name[0]).isupper():
        l.append(name[0])
print(sep.join(l)+sep)



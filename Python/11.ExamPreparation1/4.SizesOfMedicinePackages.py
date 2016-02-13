class Medicine:

    def __init__(self, name, size):
        self.name = name
        self.size = size

    def __str__(self):
        return "Medicine: Name: {}, Size: W= {}, H= {}, D= {}".format(
            self.name,
            self.size[0],
            self.size[1],
            self.size[2]
        )


def load_medicines_from_file(filename):
    medicines_list = []
    with open(filename, encoding='utf-8') as f:
        for line in f:
            product = line.strip().split(",")
            temp = []
            temp.append(float(product[1]))
            temp.append(float(product[2]))
            temp.append(float(product[3]))
            medicines_list.append(Medicine(name=product[0],
                                  size=temp))
        return medicines_list

package_size = []
for i in range(3):
    input_string = input()
    try:
        package_size.append(float(input_string))
    except:
        print("INVALID INPUT")
filename = input()
package_size.sort()
medicines = load_medicines_from_file(filename)

for value in medicines:
    value.size.sort()
    flag = True
    for i in range(len(value.size)):
        temp = value.size
        if temp[i] > package_size[i]:
            flag = False
    if flag:
        print(value.name)






class Medicine:

    def __init__(self, name, w, h, d):
        self.name = name
        self.w = w
        self.h = h
        self.d = d


def load_medicines_from_file(filename):
    medicines = []
    with open(filename, encoding='utf-8') as f:
        for line in f:
            product = line.strip().split(" ")
            medicines.append(Medicine(name=product[0],
                                w=product[1],
                                h=product[2],
                                d=product[3]))
        return medicines
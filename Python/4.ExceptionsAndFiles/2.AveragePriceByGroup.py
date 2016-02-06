""" Find the average price of products listed
in a file and grouped by gender
"""
FILENAME = './CommonResources/catalog_sample.csv'

products_count = {
    'Infant': 0,
    'Kid': 0,
    'Men': 0,
    'Woman': 0,
    'Unisex': 0
}

sum_bytype = {
    'Infant': 0.0,
    'Kid': 0.0,
    'Men': 0.0,
    'Woman': 0.0,
    'Unisex': 0.0
}

with open(FILENAME) as f:
    for line in f:
        product = line.strip().split(",")
        products_count['{}'.format(product[-2])] += 1
        sum_bytype['{}'.format(product[-2])] += float(product[-1])

for key, value in sum_bytype.items():
    print("The average price of {} products is: {:.2f}".format(key, sum_bytype[key]/products_count[key]))

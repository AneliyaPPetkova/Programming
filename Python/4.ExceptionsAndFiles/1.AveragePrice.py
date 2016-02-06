""" Find the average price of products listed in a file
"""
sum = 0.0
rows = 0
with open('./CommonResources/catalog_sample.csv') as f:
    for line in f:
        rows += 1
        product = line.strip().split(",")
        sum += float(product[-1])
print("The average price of all {} products is: {}".format(rows, sum/rows))

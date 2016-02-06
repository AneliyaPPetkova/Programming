""" Change all prices in the file
"""
import random

FILENAME = './CommonResources/catalog_sample.csv'
changed_catalog = './CommonResources/changed_catalog.csv'
sep = ","

with open(FILENAME) as f:
    with open(changed_catalog, 'w') as w:
        for line in f:
            product = line.strip().split(sep)
            product[-1] = "{:.2f}".format(random.uniform(100.0, 999.0))
            w.write(sep.join(product))
            w.write("\n")

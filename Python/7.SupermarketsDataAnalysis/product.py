import csv
class Product:

    def __init__(self, product_id, category):
        self.product_id = product_id
        self.category = category

        if any(v is None for v in [self.product_id, self.category]):
            raise ValueError('Arguments missing')

    def __str__(self):
        return "Product: {}, Category: {}".format(
            self.product_id,
            self.category
        )


def load_catalog_from_file(filename):
    catalog = {}
    with open(filename) as f:
        csvReader = csv.reader(f)
        for line in csvReader:
            product = Product(product_id=line[0], category=line[5])
            catalog[product.product_id] = product.category
        return catalog

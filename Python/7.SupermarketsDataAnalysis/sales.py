class Sale:

    def __init__(self, product_id, country_code, city, sale_datetime, price):
        self.product_id = product_id
        self.country_code = country_code
        self.city = city
        self.sale_datetime = sale_datetime
        self.price = price

        if any(v is None for v in [self.product_id, self.country_code,
                                   self.city, self.sale_datetime, self.price]):
            raise ValueError('Arguments missing')


def load_catalog_from_file(filename):
    catalog = []
    with open(filename) as f:
        for line in f:
            temp = line.strip().split(",")
            catalog.append(Sale(product_id=temp[0],
                                country_code=temp[1],
                                city=temp[2],
                                sale_datetime=temp[3],
                                price=temp[4]))
        return catalog


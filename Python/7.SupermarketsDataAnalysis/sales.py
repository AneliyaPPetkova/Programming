import iso8601
import csv
from datetime import datetime, timezone


class Sale:

    def __init__(self, product_id, country_code, city, sale_datetime, price):
        self.product_id = product_id
        self.country_code = country_code
        self.city = city
        self.sale_datetime = iso8601.parse_date(sale_datetime).astimezone(timezone.utc)
        self.price = float(price)

        if any(v is None for v in [self.product_id, self.country_code,
                                   self.city, self.sale_datetime, self.price]):
            raise ValueError('Arguments missing')

    def __str__(self):
        return "Sale: Product: {}, Country code: {}, City: {}, DateTime: {}, Price: {}".format(
            self.product_id,
            self.country_code,
            self.city,
            self.sale_datetime,
            self.price
        )


def load_sales_from_file(filename):
    sales = []
    with open(filename) as f:
        csvReader = csv.reader(f)
        for line in csvReader:
            sales.append(Sale(product_id=line[0],
                                country_code=line[1],
                                city=line[2],
                                sale_datetime=line[3],
                                price=line[4]))
        return sales


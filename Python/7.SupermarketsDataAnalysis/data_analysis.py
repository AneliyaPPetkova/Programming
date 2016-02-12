import sys
from sales import load_sales_from_file
from product import load_catalog_from_file
from collections import OrderedDict

def main():
    salesFile = './CommonResources/sales-10K.csv'
    catalogFile = './CommonResources/catalog.csv'
    # for value in load_catalog_from_file(FILENAME):
    #     print(value)
    sales = load_sales_from_file(salesFile)
    catalog = load_catalog_from_file(catalogFile)
    print_sales_summary(sales)
    print_sum_of_sales_by_category(catalog, sales)
    print_sum_of_sales_by_city(sales)
    print_sum_of_sales_by_datetime(sales)


def print_sales_summary(input_data: list):
    sum_of_sales = 0.0
    for data in input_data:
        sum_of_sales += float(data.price)
    average_price = sum_of_sales/len(input_data)
    oldestDate = min(dt.sale_datetime for dt in input_data)
    youngestDate = max(dt.sale_datetime for dt in input_data)
    print("""
Обобщение
---------------------
Общ брой продажби: {}
Общо сума продажби: {:.2f} €
Средна цена на продажба: {:.2f} €
Начало на период на данните: {}
Край на период на данните: {}""".format(len(input_data), sum_of_sales, average_price, oldestDate, youngestDate))


def print_sum_of_sales_by_category(catalog: dict, sales: list):
    sales_by_category = {}
    for sale in sales:
        if sale.product_id in catalog:
            if catalog[sale.product_id] not in sales_by_category:
                sales_by_category[catalog[sale.product_id]] = 0.0
            sales_by_category[catalog[sale.product_id]] += sale.price
    sorted_dict = OrderedDict(sorted(sales_by_category.items(), key=lambda x: x[1], reverse=True))
    count = 0
    print("""
Сума на продажби по категории (top 5)
---------------------""")
    for key, value in sorted_dict.items():
        if count == 5:
            break
        print("{}: {:.2f} €".format(key, value))
        count += 1


def print_sum_of_sales_by_city(sales: list):
    sales_by_city = {}
    for sale in sales:
        if sale.city not in sales_by_city:
            sales_by_city[sale.city] = 0.0
        sales_by_city[sale.city] += sale.price
    sorted_dict = OrderedDict(sorted(sales_by_city.items(), key=lambda x: x[1], reverse=True))
    max_value = max(sorted_dict.items(), key=lambda x:x[1])[1]
    count = 0
    print("""
Сума на продажби по градове (top 5)
---------------------""")
    for key, value in sorted_dict.items():
        test = print_stars(value, max_value)
        if count == 5:
            break
        count += 1
        print("{:15s}: ".format(key, value), end="")
        for i in range(0, round(test)):
            print('*', end="")
        print("{:.2f} €".format(value))



def print_sum_of_sales_by_datetime(sales: list):
    sales_by_datetime = {}
    for sale in sales:
        temp = sale.sale_datetime
        # dayAndTime = temp.strftime('%Y-%m-%d %H:%M')
        sales_hour = str(temp.hour)
        sales_date = temp.date()
        dayAndTime = '{} {}:00'.format(sales_date, sales_hour)
        if dayAndTime not in sales_by_datetime:
            sales_by_datetime[dayAndTime] = 0.0
        sales_by_datetime[dayAndTime] += sale.price
    sorted_dict = OrderedDict(sorted(sales_by_datetime.items(), key=lambda x: x[1], reverse=True))
    count = 0
    print("""
Часове с най-голяма сума продажби (top 5)
---------------------""")
    for key, value in sorted_dict.items():
        if count == 5:
            break
        print("{} : {:.2f} €".format(key, value))
        count += 1


def print_stars(price_value: float, max_value: float):
    max_stars = 30.0
    number_of_stars = (price_value/max_value)*max_stars
    return number_of_stars

if __name__ == "__main__":
    sys.exit(main())


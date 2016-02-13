import sys

product_id = input()
filename = input()
products_list = []
with open(filename, encoding='utf-8') as f:
        for line in f:
            product = line.strip().split(",")
            products_list.append(product)

lowest_price = sys.float_info.max
city_with_lowest_price = ""
for product in products_list:
    product[0] = product[0].strip('\"')
    price = float(product[-1])
    if product[0] == product_id and price < lowest_price:
        lowest_price = price
        city_with_lowest_price = product[2].strip('\"')

print(city_with_lowest_price)

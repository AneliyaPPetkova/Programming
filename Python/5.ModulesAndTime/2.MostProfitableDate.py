""" Find the most profitable date from a file with data
"""
from datetime import datetime
from datetime import date

FILENAME = './CommonResources/sales.csv'
sales = {}
max = 0.0
dateWithMaxSales = date.today()

with open(FILENAME) as f:
    for line in f:
        sale = line.strip().split(",")
        dayAndTime = datetime.strptime(sale[0], '%Y-%m-%d %H:%M:%S')
        salesDate = dayAndTime.date()

        if '{}'.format(salesDate) not in sales:
            sales['{}'.format(salesDate)] = float(sale[1])
        else:
            sales['{}'.format(salesDate)] += float(sale[1])

    for key, value in sales.items():
        if value > max:
            max = value
            dateWithMaxSales = key
print(sales)
print("The most profitable day is {} with {} profit.".format(dateWithMaxSales, max))

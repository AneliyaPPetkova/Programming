""" Find the most profitable hour from a file with data
"""
from datetime import datetime
from datetime import date

FILENAME = './CommonResources/sales.csv'
sales = {}
maxProfit = 0.0
hourWithMaxSales = datetime.now().hour

with open(FILENAME) as f:
    for line in f:
        sale = line.strip().split(",")
        dayAndTime = datetime.strptime(sale[0], '%Y-%m-%d %H:%M:%S')
        salesHour = dayAndTime.hour

        if '{}'.format(salesHour) not in sales:
            sales['{}'.format(salesHour)] = float(sale[1])
        else:
            sales['{}'.format(salesHour)] += float(sale[1])

for key, value in sales.items():
    if value > maxProfit:
        maxProfit = value
        hourWithMaxSales = key

print("The most profitable hour is {} with {} profit.".format(hourWithMaxSales, maxProfit))

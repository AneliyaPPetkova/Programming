import os
import csv

filename = input()
temperature = 60.0
with open(filename) as f:
    csvReader = csv.reader(f)
    for line in csvReader:
        if temperature + 4.0 < float(line[1]):
            print(line[0])
        temperature = float(line[1])

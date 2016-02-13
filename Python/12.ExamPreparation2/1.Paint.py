import math

try:
    input_w = float(input())
    input_h = float(input())
except:
    print("INVALID INPUT")

bottle_in_litres = 1.76

result = math.ceil((input_w*input_h)/bottle_in_litres)

print(result)

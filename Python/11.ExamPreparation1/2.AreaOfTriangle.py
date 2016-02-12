import math

triangle_sides = []
for i in range(3):
    input_string = input()
    try:
        triangle_sides.append(float(input_string))
    except:
        print("INVALID INPUT")

if len(triangle_sides) == 3:
    a = triangle_sides[0]
    b = triangle_sides[1]
    c = triangle_sides[2]
    if a+b > c or b+c > a or a+c > b:
        perimeter = (a + b + c) / 2
        S = math.sqrt(perimeter*(perimeter-a)*(perimeter-b)*(perimeter-c))
        print('{:.2f}'.format(S))
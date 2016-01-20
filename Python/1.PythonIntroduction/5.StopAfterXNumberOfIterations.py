"""Модифицирайте този код, така че да спре да рисува след определен брой итерации:
Броят на итерациите трябва да се въвежда при стартиране на програмата с input()
"""
import turtle
turtle.color('blue')
turtle.speed('slow')

g = 134
l = 120
numberOfIterations = int(input('Enter number of iterations: '))
while numberOfIterations > 0:
    turtle.left(g)
    turtle.forward(l)
    numberOfIterations -= 1




"""С помощта на turtle нарисувайте квадрат,
като дължината на страна се въвежда от конзолата с input().
"""
import turtle
turtle.color('green')
turtle.speed('slow')

squareSideLength = input("Please, enter square side's length in cm:")

for a in range(0,4):
    turtle.forward(int(squareSideLength))
    turtle.left(90)

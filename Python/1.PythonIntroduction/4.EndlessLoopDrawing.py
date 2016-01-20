"""Направете програма, която по зададени ъгъл и дължина да рисува линии
с turtle в безкраен цикъл, като всеки път завърта костенурката на
подадения брой градуси, и рисува права линия със зададената дължина.
Ъгълът (в градуси) и дължината трябва да се въвеждат от конзолата
при стартиране на програмата. За въвеждане от конзолата използвайте функцията input().
"""
import turtle
turtle.color('blue')
turtle.speed('slow')

angle = input('Enter angle:')
length = input('Enter length')

while True:
    turtle.left(float(angle))
    turtle.forward(int(length))

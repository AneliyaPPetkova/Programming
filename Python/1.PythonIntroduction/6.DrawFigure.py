"""Използвайки цикли, аритметика, условни и логически оператори,
 накарайте костенурката да рисува "интересни неща".
"""
import turtle
turtle.color('green')
turtle.speed('fastest')

i = 100
while True:
    turtle.left(i)
    turtle.forward(10)
    turtle.backward(20)
    i -= 2
    if i == -20:
        i = 100

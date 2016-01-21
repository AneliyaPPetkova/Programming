"""Използвайки цикли, условни оператори и костенурката
 нарисувайте дъска за шах с черни и бели квадрати.
 Дъската трябва да е с размери 8 на 8 квадрата.
"""
import turtle

side = 40

for i in range(8):
    turtle.goto(0, i*-side)
    turtle.pendown()
    for j in range(8):
        if j % 2 == i % 2:
            turtle.begin_fill()
        for k in range(4):
            turtle.forward(side)
            turtle.left(90)
        turtle.end_fill()
        turtle.forward(side)
    turtle.penup()

turtle.exitonclick()

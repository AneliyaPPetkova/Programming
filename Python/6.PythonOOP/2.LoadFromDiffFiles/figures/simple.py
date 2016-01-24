import math

from .base import Figure

class Circle(Figure):

    def __init__(self, radius, **kwargs):
        super().__init__(**kwargs)
        self.radius = radius

    def draw(self, turtle):
        turtle.penup()
        turtle.goto(self.center_x, self.center_y - self.radius)  # From docs: The center is radius units left of the turtle;
        turtle.pendown()
        turtle.color(self.color)
        turtle.circle(self.radius)

class Pie(Figure):

    def __init__(self, arg_degrees, radius, **kwargs):
        super().__init__(**kwargs)
        self.arg_degrees = arg_degrees
        self.radius = radius

    def draw(self, turtle):
        turtle.penup()
        turtle.goto(self.center_x, self.center_y - self.radius)  # From docs: The center is radius units left of the turtle;
        turtle.pendown()
        turtle.color(self.color)
        turtle.circle(self.radius, self.arg_degrees)

class Square(Figure):

    def __init__(self, side, **kwargs):
        super().__init__(**kwargs)
        self.side = side

    def draw(self, turtle):
        half_side = self.side / 2
        left = self.center_x - half_side
        top = self.center_y + half_side

        turtle.penup()
        turtle.goto(left, top)
        turtle.pendown()
        turtle.color(self.color)
        turtle.forward(1)
        turtle.setheading(270)  # point the turtle down
        for _ in range(4):
            turtle.forward(self.side)
            turtle.left(90)

class Rectangle(Figure):

    def __init__(self, width, height, **kwargs):
        super().__init__(**kwargs)
        self.width = width
        self.height = height

    def draw(self, turtle):
        half_width = self.width / 2
        half_height = self.height / 2
        left = self.center_x - half_width
        top = self.center_y + half_height

        turtle.penup()
        turtle.goto(left, top)
        turtle.pendown()
        turtle.color(self.color)
        turtle.forward(1)
        turtle.setheading(270)  # point the turtle down
        for _ in range(2):
            turtle.forward(self.height)
            turtle.left(90)
            turtle.forward(self.width)
            turtle.left(90)

class Polygon(Figure):

    def __init__(self, radius, n_sides, **kwargs):
        super().__init__(**kwargs)
        self.radius = radius
        self.n_sides = n_sides


    def draw(self, turtle):
        side = 2*self.radius*math.sin(math.radians(180/self.n_sides))
        turtle.penup()
        turtle.setheading(270 + (360/self.n_sides)/2)  # point the turtle down
        turtle.forward(self.radius)
        turtle.pendown()
        turtle.setheading(0)
        turtle.color(self.color)

        for _ in range(self.n_sides):
            turtle.left(360/self.n_sides)
            turtle.forward(side)


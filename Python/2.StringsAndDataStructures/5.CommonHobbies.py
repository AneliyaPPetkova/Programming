""" You have two lists, containing the hobbies of Ivan and Maria.
Write a program to display only the common hobbies of both of them.
"""

ivan = ['пушене', 'пиене', 'тия три неща', 'коли', 'facebook', 'игри', 'разходки по плажа', 'скандинавска поезия']
maria = ['пиене', 'мода', 'facebook', 'игри', 'лов със соколи', 'шопинг', 'кино']
commonHobbies = list()

for h in ivan:
    if h in maria:
        commonHobbies.append(h)

print("The common hobbies of Ivan and Maria are {}".format(commonHobbies))


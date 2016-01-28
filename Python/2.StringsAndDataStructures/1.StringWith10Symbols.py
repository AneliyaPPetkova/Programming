"""Напишете програма, която взима текст от потребителя
използвайки input() и ограничава текста до 10 символа и добавя ... накрая
"""
stringInput = input()

if len(stringInput) >= 10:
    print(stringInput[:10] + "...")
else:
    print(stringInput)

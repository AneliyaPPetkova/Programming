filename_exchange_rates = input()
filename_amounts = input()

exchange = {}

with open(filename_exchange_rates, encoding='utf-8') as f:
    for line in f:
        ex = line.strip().split(" ")
        if ex[0] not in exchange:
            exchange[ex[0]] = float(ex[1])

with open(filename_amounts, encoding='utf-8') as f:
    for line in f:
        am = line.strip().split(" ")
        if am[1] in exchange:
            print('{:.2f}'.format(float(am[0])/exchange[am[1]]))

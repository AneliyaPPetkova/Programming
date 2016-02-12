input_string = input()

if input_string.isspace() or input_string == "":
    print("INVALID INPUT")
else:
    symbols = {}
    for s in input_string:
        if s not in symbols:
            symbols[s] = 0
        symbols[s] += 1
    most_common_symbol = max(symbols.items(), key=lambda x:x[1])[0]
    print(most_common_symbol)

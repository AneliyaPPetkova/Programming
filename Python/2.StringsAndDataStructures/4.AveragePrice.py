print("Enter prices. If 'stop' is entered, "
      "the program will calculate the average price from the list with prices:")

prices = []
enter = True
while enter:
    stringInput = input()
    if stringInput.isdigit():
        prices.append(float(stringInput))
    elif stringInput == "stop":
        enter = False

print(prices)

if len(prices) >= 4:
    maxPrice = max(prices)
    print("The Max price is {}".format(maxPrice))
    prices.remove(maxPrice)

    minPrice = min(prices)
    print("The Min price is {}".format(minPrice))
    prices.remove(minPrice)
    print(prices)
    if len(prices) > 1:
        sumPrice = 0
        for price in prices:
            sumPrice += float(price)

        average = sumPrice / len(prices)
        print("Average price is {}".format(average))
else:
    print("The remaining values are {} so average price could not be calculated.".format(len(prices)))


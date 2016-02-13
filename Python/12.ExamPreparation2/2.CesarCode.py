try:
    input_key = int(input())
    input_key = input_key%26
    input_text = input()

    def find_code(code:int):
        temp_code = 0
        if code+input_key > last_letter_code:
            temp_code = first_letter_code - 1 + (input_key - (last_letter_code - code))
        else:
            temp_code = code+input_key
        return temp_code

    if input_text.isspace() or input_text == "":
        print("INVALID INPUT")
    else:
        first_letter_code = ord("A")
        last_letter_code = ord("Z")
        result = []
        for symbol in input_text:
            if first_letter_code <= ord(symbol) <= last_letter_code:
                print(chr(find_code(ord(symbol))), end="")
            elif symbol.isalpha() and symbol.islower():
                print("INVALID INPUT")
                break
            else:
                print(symbol, end="")
except:
    print("INVALID INPUT")



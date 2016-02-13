try:
    filename = input()
except:
    print("INVALID INPUT")

sections_list = []
time = 0.0
with open(filename, encoding='utf-8') as f:
        for line in f:
            if not line.isspace():
                section = line.strip().split(",")
                sections_list.append(section)
            else:
                print("INVALID INPUT")

try:
    for section in sections_list:
        km_from = int(section[0])
        km_to = int(section[1])
        speed = int(section[2])
        time += (km_to - km_from + 1)/speed
    print('{:.2f}'.format(time))
except:
    print("INVALID INPUT")
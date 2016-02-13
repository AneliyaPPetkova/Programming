import sys
import os

try:
    filename = input()
    if not os.path.isfile(filename):
            raise Exception

    word = input()
    if word.isspace() or word == '':
        raise Exception
    else:
        sorted_word = ''.join(sorted(word))
        word_list =[]
        with open(filename, encoding='utf-8') as f:
            for line in f:
                if not line.isspace() or line.isalnum():
                    temp = line.strip()
                    temp_sorted = ''.join(sorted(temp))
                    if temp_sorted == sorted_word and temp != word:
                        word_list.append(temp)
        if len(word_list) > 0:
            word_list.sort()
            for w in word_list:
                print(w)
        else:
            print("NO ANAGRAMS")
except:
    print("INVALID INPUT")


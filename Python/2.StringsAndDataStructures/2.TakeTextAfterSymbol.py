"""Ask the user to enter two input strings. Print the substring from the first
 string which is found after the second string.
 If the second string is not found in the first string, print the whole first string.
"""
firstString = input("First text: ")
secondString = input("Second text: ")

secondStringIndex = firstString.find(secondString)
if secondStringIndex != -1:
    print(firstString[(secondStringIndex + len(secondString)):])
else:
    print(firstString)

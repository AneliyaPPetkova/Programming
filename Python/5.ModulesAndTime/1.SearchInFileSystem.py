""" Search files in file system.
Example:
  python3  find.py  /home/user/Downloads  me.jpg
"""

import sys
import os


def main():
    if len(sys.argv) < 3:
        print("Please provide at least 3 parameters")
    else:
        find_file(dir=sys.argv[1], filename=sys.argv[2])


def find_file(dir, filename):
    fileList = []
    for dirpath, dirnames, filenames in os.walk(dir):
        for name in filenames:
            if filename == name:
                fileList.append(os.path.join(dirpath, name))

    if len(fileList) > 0:
        for file in fileList:
            print("The file is found: {}".format(file))
    else:
        print("The file doesn't exist!")

if __name__ == "__main__":
    sys.exit(main())
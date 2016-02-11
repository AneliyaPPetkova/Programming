import sys
from sales import load_catalog_from_file


def main():
    FILENAME = './CommonResources/sales-10K.csv'
    for value in load_catalog_from_file(FILENAME):
        print(value)

if __name__ == "__main__":
    sys.exit(main())




import requests
from bs4 import BeautifulSoup
import csv

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

response = requests.get(url)
print(response)

soup = BeautifulSoup(response.content, 'html.parser')

print("\nPage Title:", soup.title)

input("\nPress Enter to continue...")


books = soup.find_all('article', class_='product_pod')

print("\nTotal books found:", len(books))

input("\nPress Enter to extract data...")

rows = []

for book in books:
    title = book.h3.a['title']
    price = book.find('p', class_='price_color').text
    rating = book.p['class'][1]

    print("\nTitle:", title)
    print("Price:", price)
    print("Rating:", rating)

    rows.append((title, rating, price))


fname = "books.csv"

try:
    with open(fname, "w+", newline='', encoding='utf-8') as f:
        writer = csv.writer(f)

        writer.writerow(["Title", "Rating", "Price"])
        writer.writerows(rows)

        print("\nCSV file created successfully")

        input("\nPress Enter to display data...")

        f.seek(0)
        reader = csv.reader(f)

        for row in reader:
            print(row)

except Exception as e:
    print(e)
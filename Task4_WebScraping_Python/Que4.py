import requests
from bs4 import BeautifulSoup
import csv

# URL to scrape
url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"

# request webpage
response = requests.get(url)

soup = BeautifulSoup(response.text, "html.parser")

books = soup.find_all("article", class_="product_pod")

book_data = []

for book in books:
    title = book.h3.a["title"]

    price = book.find("p", class_="price_color").text

    rating = book.p["class"][1]

    book_data.append([title, rating, price])

# save data to CSV
with open("books.csv", "w", newline="", encoding="utf-8") as file:
    writer = csv.writer(file)

    writer.writerow(["Title", "Rating", "Price"])

    writer.writerows(book_data)

print("Data saved to books.csv")

# read CSV file and display results
print("\nBooks from CSV:\n")

with open("books.csv", "r", encoding="utf-8") as file:
    reader = csv.reader(file)

    for row in reader:
        print(row)
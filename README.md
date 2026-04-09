 Technologies Used

- C# (.NET 10)
- Python 3
- SQLite
- BeautifulSoup
- MSTest
- Git & GitHub

 Task Details

Task 1 Churros Ordering System (C#)
- Menu-driven console application
- Uses Queue<Order> (FIFO)
- Makes distinct order numbers.
- Implements:
  - pay_bill()
  - collect_order()
- Includes unit testing (MSTest)

Task 2 Periodic Table (C#)
- Uses Dictionary<int, Element>
- Stores first 30 elements
- Fast lookup using atomic number
- Console-based interactive system

Task 3: Client-Server System (Python).
- TCP socket programming
- User data sent by client.
- Server:
  - Generates registration ID
  - Saves the data to SQLite database.
- Shows actual communications system.

 Task 4 - Web Scraping (Python)
- Scrapes Book To Scrape Data.
- Extracts:
  - Title
  - Price
  - Rating
- Writes the information in CSV file.
- Shows findings on terminal.

 Unit Testing

- Implemented using MSTest
- Tested:
  - Bill calculation
  - Edge cases (zero quantity)
  - Generation of unique order ID.

 Screenshots

All outputs and results are available in the screenshots/ folder, including:
- Task outputs
- Unit test results
- Client-server communication
- Web scraping results

 How to Run

 C# Projects
```bash
cd Task1ChurrosCSharp
dotnet run

cd Task3_ClientServer_Python
python Que3_server.py

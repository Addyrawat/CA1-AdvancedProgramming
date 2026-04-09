

import socket
import sqlite3


conn = sqlite3.connect("customers.db")
cur = conn.cursor()

cur.execute("""
CREATE TABLE IF NOT EXISTS customers(
reg_no TEXT,
name TEXT,
address TEXT,
pps TEXT,
license TEXT
)
""")

conn.commit()

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind(("localhost", 5000))
server.listen(1)

print("Server is running...")
print("Waiting for client...")

conn_socket, addr = server.accept()

print("Client connected:", addr)


data = conn_socket.recv(1024).decode()

values = data.split(",")

name = values[0]
address = values[1]
pps = values[2]
license_no = values[3]


import random
reg_no = "REG" + str(random.randint(1000, 9999))


cur.execute("INSERT INTO customers VALUES (?,?,?,?,?)",
            (reg_no, name, address, pps, license_no))

conn.commit()

print("Data stored successfully")


conn_socket.send(reg_no.encode())

conn_socket.close()
conn.close()
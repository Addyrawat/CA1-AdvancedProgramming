import socket
import sqlite3
import random

# create database connection
conn = sqlite3.connect("customers.db")
cursor = conn.cursor()

# create table if not exists
cursor.execute("""
CREATE TABLE IF NOT EXISTS customers(
    reg_no TEXT,
    name TEXT,
    address TEXT,
    pps TEXT,
    license TEXT
)
""")

conn.commit()

# create socket server
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

server.bind(("localhost", 5000))

server.listen(1)

print("Server started... Waiting for client connection")

conn_socket, addr = server.accept()

print("Client connected:", addr)

data = conn_socket.recv(1024).decode()

details = data.split(",")

name = details[0]
address = details[1]
pps = details[2]
license_no = details[3]

# generate registration number
reg_no = "REG" + str(random.randint(1000,9999))

cursor.execute("INSERT INTO customers VALUES (?,?,?,?,?)",
               (reg_no,name,address,pps,license_no))

conn.commit()

print("Customer stored in database")

conn_socket.send(reg_no.encode())

conn_socket.close()

conn.close()
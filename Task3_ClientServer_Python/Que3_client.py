# Topic: Client-Server Programming
# Example: TCP Client

import socket

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

client.connect(("localhost", 5000))

print("Enter Customer Details")

name = input("Name: ")
address = input("Address: ")
pps = input("PPS Number: ")
license_no = input("Driving License: ")

data = name + "," + address + "," + pps + "," + license_no

client.send(data.encode())

reg_no = client.recv(1024).decode()

print("\nRegistration Successful")
print("Registration Number:", reg_no)

client.close()
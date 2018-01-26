# SilverSteel Inventory Management System
The Silver Steel Inventory Management System is a Visual Basic program designed to automatically track changes, inventory and sales.
Introduction
Carwash and KTV
DATABASE

Purpose
The SilverSteel IMS is an Automated IMS made for the purpose of cataloging the products in our Carwash. It is meant to automate the process of cataloging our items by easily sending data into our database, which saves much time as compared to when we manually record it into a notebook. The management system requires a computer running on Microsoft .NET framework Version 3. It must be running on a x32 kernel or a x86 architecture. The system requires complete libraries of OleDb, and SQL to function. 

Scope
	The software will be a Database Management System and a Command Center for the following functions.

The Restaurant
Inventory Management
Carwash
Real-Time Tracking
Report Generator
	
	This program will be able to track the time of car wash customers, and list them in a database to generate a daily report. This program will also track restaurant inventory changes - allowing for a systematic view. The software is essential in automation and is low-cost compared to paper reports and manual listing which takes time, effort and paper. 

	This does not include automatic diagnosis or checking of the database, nor a heurestic engine to check if the inventory is running low. It is only a program to display the information in a grid, and the user must be able to interpret the data.

Definition of Terms

Term
Definition
User
Describes the end user of this product, usually the cashier or manager staff.
Customers
They will encompass the reports, the services given to them will be listed and tallied in the database.
Services
Describes the services available for the customers, which also will be tallied in the system.
Graphical User Interface
Describes the program that will be seen through the monitor - the visible aspect.
Main Module
This is in the program, it is assigned as mainmodule.vb. It contains critical code, functions and variables.
OleDb Connection
Connection which the program uses to access the Database.
Database
This is defined in the program as imsdb.mdb. This is where all data is located and saved. Reports are also generated in this program.
Report
This is a printable format of data documented by the system in the Database file.



Product Perspectives

Subsystems
Inventory Management
Real Time Tracking
Report Generation
Main Module Subsystem
Allows loading of values and connections in the program.
Allows the temporary listing of data of car wash time for redundancy.
Allows generation of results from the database.
Database
imsdb.mdb
Saves the data inputted in the program.


The reports are referred to from this database.
OleDb Adaptor
Used to connect to the database thru Microsoft JET.

Product Functions

Function
Description
Inventory Management
Management of the inventory of the Restaurant. Three modules are used to manage this in the program, namely mainmodule.vb, inventory.vb and the imsdb.mdb
Real Time Tracking
Describes the capability of the program to track cleaning time of the carwash in both in a GUI methodology and through tracking.
Report Generator
Describes the capability of the program to graph and print out the results of certain conditions, such as days and hours of services that were used in that timeframe.

Constraints

Requires Microsoft .NET Framework Version 3 to run.
Can only run in x86 architecture programs as it uses an old version of Microsoft.JET adaptor.
Cannot shutdown in saving functions as it would corrupt the system.
There is no function to backup the database - if it is deleted there is no backup.
The database has no password.
The program has no brute force protection mechanisms from password cracking in the main menu.


Specific Requirements

This section provides a detailed description of all the precise specification of each function in this program.


The one who will use this program should see the log-in page when he/she opens the application. If the user has not registered, he/she should be able to do that in the log-in page.








After the user has successfully logged in. the program will go the main menu in which you can see the slots of the carwash(left) and the KTV(right). 																			



The user can use a slot in the car wash by clicking file>open>car wash that is the same for the KTV. In the new car wash(as seen in picture) you can be able to edit the car wash slot, time start, plate number, their car description, and etc. Once the user is finished on filling the information you can now click set to start the  time. This can be maximized up to 6 slots. 

Function Requirements






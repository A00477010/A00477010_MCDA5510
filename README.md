# \_MCDA5510

Assigment 1
Project Description:
Write a C# program to traverse a directory structure (DirWalker.cs) of CSV files
that contain CSV files with customer info. A simple sample is provided in with the
sample code, but you MUST run against a larger data set.

Objective ->

The main objective of this program is to process CSV files containing customer information. The program should perform the following tasks:

Traverse a directory structure.
Process CSV files with customer information.
Log information and exceptions.
Handle incomplete records in the CSV files.
Calculate and log the total execution time, valid rows, and skipped rows.
Add the date as a new data column to the processed CSV files.

Requirements ->

To run this program, you need to meet the following requirements:

A C# development environment, preferably Visual Studio.
A larger dataset of CSV files containing customer information to test against.
Set up logging for both informational messages and exceptions.

Program structure ->
csvData.cs :This file contains the structure of the record.
Logger.cs: This file contains the logger class
Program.cs: This file contains the main method which is called on executing the code.

CSV Directory Traversal Program
<<<<<<< HEAD
This C# program is designed to traverse a directory structure and process CSV files containing customer information. The program utilizes the DirWalker.cs module to navigate through directories, and it processes CSV files using the CSV library. This README will provide an overview of the program, its functionality, and how to run it.
=======
This C# program is designed to traverse a directory structure and process CSV files containing customer information. The program utilizes the Program.cs module to navigate through directories, and it processes CSV files using the CSV library. This README will provide an overview of the program, its functionality, and how to run it.
>>>>>>> 134b0e1c6f68c80948b050bfccfdcd1f4253de9e

Project Description
Objective
The main objective of this program is to process CSV files containing customer information. The program should perform the following tasks:

Traverse a directory structure.
Process CSV files with customer information.
Log information and exceptions.
Handle incomplete records in the CSV files.
Calculate and log the total execution time, valid rows, and skipped rows.
Add the date as a new data column to the processed CSV files.
Requirements
To run this program, you need to meet the following requirements:

A C# development environment, preferably Visual Studio.
A larger dataset of CSV files containing customer information to test against.
<<<<<<< HEAD
Ensure the DirWalker.cs module and the CSV library are available in your project.
Set up logging for both informational messages and exceptions.
Project Structure
The project includes the following files and directories:

Program.cs: The main program file that orchestrates the CSV processing.
DirWalker.cs: A module for traversing the directory structure.
Output/: A directory to store the result file.
Sample CSV files: A sample dataset is provided, but you should run the program against a larger dataset.
=======
Ensure the Program.cs module and the CSV library are available in your project.
Set up logging for both informational messages and exceptions.


>>>>>>> 134b0e1c6f68c80948b050bfccfdcd1f4253de9e

Data Columns ->
The CSV files should contain the following data columns:

First Name
Last Name
Street Number
Street
City
Province
Country
Postal Code
Phone Number
Email Address
Adding Date Column
The program will add a new date column in the format "yyyy/mm/dd" to the processed CSV files.

<<<<<<< HEAD
When the mainmethod is called from the program.cs , it will travserse all the csv files from the given path. These files will be checked for validations. Valid data will be updated in the Output.csv file and the invalid records will be logged to the log file.
=======
When the main method is called from the program.cs , it will travserse all the csv files from the given path. These files will be checked for validations. Valid data will be updated in the Output.csv file and the invalid records will be logged to the log file.
>>>>>>> 134b0e1c6f68c80948b050bfccfdcd1f4253de9e

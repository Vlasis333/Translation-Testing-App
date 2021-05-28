# Translation-testing-app
A simple application (made using VB.net and SQL DB) that lets you insert a German word with it's Greek translation. Then you can select a random word from the data base either greek or german and try to translate it (with a button for the solution). Also has diffrent group categories.

Installation:

Step 1: Download project <br />
Step 2: Install SQL Server Express 2014 (if not installed) <br />
Step 3: Add the .bak file to your data base (using SQL management studio) <br />

this steps are hard coded as this application I have made it for a friend and wanted to help her with that,
and didnt make it thought code.

Step 4: Run the executable file inside the original location (DON'T MOVE FILES)

Enjoy.


Small Bug Fix: (DO it before running the program) <br />
Step 1: Open SQL Management Studio <br />
Step 2: Run the following command <br />

USE [SiaDB] <br />
GO <br />

ALTER TABLE [MainTable] <br />
ALTER COLUMN [German] nvarchar(200) <br />
GO <br />

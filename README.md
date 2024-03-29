# Student-Managment-System-winForms-Database-Project
This is my 4rth Semester Project 


The Student Management System (SMS) is a centralized system used by teachers,
students, and administrators to collect information needed to manage all core features of a school's
operations. The system provides various functionalities to manage teacher data records, student
data records, class records, and administrative tasks. This manual will guide you through the
development process of a Student Management System that contains functionalities of three major
entities i.e., teachers, students, and classes.



Features:
The SMS system should contain the following features:

Administrator Module:

Add new Teacher: The system should ask for the following credentials to register a new teacher:
• First Name
• Last Name
• T-id (should be auto-generated by the system in increasing order) [format should be
Teacher e.g., 1 for the first teacher and 1001 for one thousand and one teacher number]
• Username
• Email
• Registration Date
• Gender
• Blood Group
• Contact No
• Address



Add new Student: The system should ask for the following credentials to register a new student:
• First Name
• Last Name
• S-id (should be auto-generated by the system in increasing order) [format should be Student
e.g., 1 for the first student and 1001 for one thousand and one student number]
• Registration Date
• Gender
• Contact No
• Blood Group
• Address
• Fees paid status (true/false)


Edit Teacher details: The system should allow the administrator to edit the following details of a
teacher:



• First Name
• Last Name
• Address
• Contact No
• Username
• Email




Edit Student details: The system should allow the administrator to edit the following details of a
student:
• First Name
• Last Name
• Address
• Contact No
• Username
• Email





Teacher Module:
View Student List: The system should allow the teacher to view the list of all students along with
their details.

Add Attendance: The system should allow the teacher to mark attendance for each student.
View Class List: The system should allow the teacher to view a list of all classes that they teach,
along with the details of each student enrolled in each class.

View Attendance Report: The system should allow the teacher to view the attendance report of
each student.

The attendance records should include the following information for each student:

• Name
• Roll Number
• Total Number of Classes
• Number of Classes Attended
• Percentage of Attendance




Student Module:

View Attendance Report: The system should allow the student to view his/her attendance report.

View Class Schedule: The system should allow the students to view their class Schedule.



Class Module:

Create New Class: The system should allow the administrator to create a new class.


Add Students to Class: The system should allow the administrator to add students to a class.
View Class List: The system should allow the administrator to view the list of all classes along
with their details.


View Student List in Class: The system should allow the administrator to view the list of students
in a class.


Schedule Class: The system should allow the administrator to schedule a class by setting the class
start time, end time, and the day(s) of the week it occurs. The system should also allow the
administrator to assign a teacher to the class and a classroom location. Once scheduled, the class
information should be stored in a database table named "class_schedule".


User Authentication:
• The system should have a login system for the administrator, teacher, and student. • The
system should have password hashing and salting to ensure the security of user data.

Database Integration:
The system should use a database to store all the data.
Technology Stack:


The following technologies are recommended for developing the SMS system:

• Domain: Web application OR Desktop application

• Database: Oracle (Mandatory)
Concept Rubrics:

All the major concepts (SQL & PL/SQL) should be used to implement project features. Your
project will be evaluated accordingly.
Note:
• SQL (DDL, DML, DCL, Grouping, Nested queries, joins, Views, Indexing, Built-in
functions)
• PL/SQL (Conditional statements, Loops, Procedures/Functions/Packages, Triggers,
Cursors)







here are some screenshots:


<img width="642" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/b8c78fb0-1f3e-4499-bced-290e97e9d55f">
<img width="646" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/2b3b8a44-a016-4207-b17c-4681aa0301e2">
<img width="648" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/870ed17c-93d6-4e3e-a402-6656e1b1dc7b">
<img width="722" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/579a846d-6b4d-42a3-a353-d7b514221431">
<img width="740" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/af13e3ab-15a8-4716-89f1-11d9fb1dad71">
<img width="908" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/f5d49abc-d394-4e0a-a3c0-90c802c28f4e">
<img width="644" alt="image" src="https://github.com/rohit546/Student-Managment-System-winForms-Database-Project/assets/100420859/04bb7681-e13d-4b8e-8b89-43c2a9c9ec5b">

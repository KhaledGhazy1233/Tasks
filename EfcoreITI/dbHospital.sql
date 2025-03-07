use Hospital
Go

create table Hospital
(
Hos_id int primary key,
Hos_name varchar(15),
phone_num varchar(15),
zip_code int unique
);
create table Hos_address
(
  Hos_address varchar(20),
  Hos_id  int , foreign key(Hos_id) references Hospital (Hos_id) 
);
create table department 
(
   Dept_id int primary key,
   Dept_Name varchar(15),
   Hos_id int ,foreign key(Hos_id) references Hospital (Hos_id)
);
create table Doctor
(
Doctor_id int primary key,
f_name varchar(15),
L_name varchar(15) ,
phone_num varchar(15),
salary int ,
Dept_id int , foreign key(Dept_id) references department(Dept_id)
);
create table Patient
(
patient_id int primary key,
f_name varchar(15) ,
l_name varchar(15) ,
phone_num varchar(15),
patient_address varchar(15) ,
doc_id int , foreign key (doc_id) references Doctor(Doctor_id)
);
INSERT INTO Hospital (Hos_id, Hos_name, phone_num, zip_code)
VALUES 
(1, 'Al Shifa', '0123456789', 12345),
(2, 'Cairo Med', '0111122334', 54321),
(3, 'El Salam', '0100987654', 67890),
(4, 'Nile Health', '0101234567', 98765),
(5, 'Al Amal', '0123456780', 13579);

INSERT INTO Hos_address (Hos_address, Hos_id)
VALUES
('123 Main St', 1),
('45 Elm St', 2),
('78 Nile Ave', 3),
('23 Tahrir Sq', 4),
('10 Giza Rd', 5);

INSERT INTO department (Dept_id, Dept_Name, Hos_id)
VALUES
(1, 'Cardiology', 1),
(2, 'Neurology', 1),
(3, 'Orthopedics', 2),
(4, 'Pediatrics', 3),
(5, 'Radiology', 4),
(6, 'Oncology', 5);

INSERT INTO Doctor (Doctor_id, f_name, L_name, phone_num, salary, Dept_id)
VALUES
(1, 'Ahmed', 'Mahmoud', '0101234567', 15000, 1),
(2, 'Sara', 'Ibrahim', '0112345678', 18000, 2),
(3, 'Khaled', 'Hassan', '0123456789', 12000, 3),
(4, 'Mona', 'Ali', '0109876543', 20000, 4),
(5, 'Omar', 'Farouk', '0119988776', 17000, 5),
(6, 'Laila', 'Youssef', '0122334455', 16000, 6);

INSERT INTO Patient (patient_id, f_name, l_name, phone_num, patient_address, doc_id)
VALUES
(1, 'Ali', 'Hassan', '0102345678', '456 Elm St', 1),
(2, 'Fatma', 'Saeed', '0113456789', '789 Nile St', 2),
(3, 'Youssef', 'Khaled', '0124567890', '123 Main St', 3),
(4, 'Nour', 'Ahmed', '0105678901', '34 Tahrir Sq', 4),
(5, 'Aisha', 'Mostafa', '0116789012', '56 Giza Rd', 5),
(6, 'Othman', 'Ali', '0127890123', '78 Al Amal St', 6);

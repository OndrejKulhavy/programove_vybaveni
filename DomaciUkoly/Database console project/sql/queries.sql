SELECT * FROM technicians;

CREATE TABLE technicians (
    id int PRIMARY KEY IDENTITY(1,1) not NULL,
    first_name varchar(50) not NULL,
    last_name varchar(50) not NULL,
    adress varchar(50) not NULL,
    city varchar(50) not NULL,
    country varchar(50) not NULL,
    zip_code varchar(50) not NULL,
    phone int not NULL,
    email varchar(50) not NULL,
    position varchar(50) not NULL,
    hourly_rate int not NULL,
    hired date not NULL,
);

create table customers(
    id int PRIMARY KEY IDENTITY(1,1) not NULL,
    first_name varchar(50) not NULL,
    last_name varchar(50) not NULL,
    adress varchar(50) not NULL,
    city varchar(50) not NULL,
    country varchar(50) not NULL,
    zip_code varchar(50) not NULL,
    phone int not NULL,
    email varchar(50) not NULL,
);

create table reports(
    id int PRIMARY KEY IDENTITY(1,1) not NULL,
    date date not NULL,
    description varchar(200) not NULL,
    price REAL not NULL,
    customer_id int not NULL FOREIGN KEY REFERENCES customers(id),
    technician_id int not NULL FOREIGN KEY REFERENCES technicians(id),
    vehicle_id int not NULL FOREIGN KEY REFERENCES vehicles(id),
);

create table vehicles(
    id int PRIMARY KEY IDENTITY(1,1) not NULL,
    company varchar(50) not NULL,
    model varchar(50) not NULL,
    year int not NULL,
    vin varchar(50) not NULL,
    customer_id int not NULL FOREIGN KEY REFERENCES customers(id),
);

create table orders(
    id int PRIMARY KEY IDENTITY(1,1) not NULL,
    name varchar(50) not NULL,
    date date not NULL,
    has_arrived bit not NULL,
    price REAL not NULL,
    report_id int not NULL FOREIGN KEY REFERENCES reports(id)
);


INSERT INTO technicians (first_name, last_name, adress, city, country, zip_code, phone, email, position, hourly_rate, hired)
VALUES
('John', 'Doe', '123 Main St', 'Los Angeles', 'USA', '90210', 5551234, 'johndoe@email.com', 'Senior Technician', 30, '2020-01-01'),
('Jane', 'Smith', '456 Oak Ave', 'New York', 'USA', '10001', 5555678, 'janesmith@email.com', 'Junior Technician', 20, '2021-02-15'),
('Mark', 'Johnson', '789 Elm St', 'Chicago', 'USA', '60601', 5559012, 'markjohnson@email.com', 'Senior Technician', 35, '2019-05-10');

INSERT INTO customers (first_name, last_name, adress, city, country, zip_code, phone, email)
VALUES
('David', 'Lee', '1234 Maple St', 'San Francisco', 'USA', '94102', 5554321, 'davidlee@email.com'),
('Emma', 'Garcia', '5678 Cedar Ave', 'Miami', 'USA', '33101', 5558765, 'emmagarcia@email.com'),
('Michael', 'Kim', '910 Oak St', 'Houston', 'USA', '77001', 5552109, 'michaelkim@email.com');

INSERT INTO reports (date, description, price, customer_id, technician_id, vehicle_id)
VALUES
('2022-01-15', 'Engine overheating', 500.00, 1, 1, 1),
('2022-02-01', 'Brake pad replacement', 300.00, 2, 2, 2),
('2022-03-10', 'Transmission repair', 800.00, 3, 3, 3);

INSERT INTO vehicles (company, model, year, vin, customer_id)
VALUES
('Toyota', 'Camry', 2018, '1234567890', 1),
('Ford', 'F150', 2019, '0987654321', 2),
('Honda', 'Accord', 2020, '2468013579', 3);

INSERT INTO orders (name, date, has_arrived, price, report_id)
VALUES
('Engine parts', '2022-01-20', 1, 200.00, 2),
('Brake pads', '2022-02-05', 1, 100.00, 3),
('Transmission fluid', '2022-03-15', 0, 50.00, 4);


DROP table technicians;
DROP table customers;
DROP table reports;
DROP table vehicles;
DROP table orders;


SELECT * FROM technicians;
SELECT * FROM customers;
SELECT * FROM reports;
SELECT * FROM vehicles;
SELECT * FROM orders;

--UPDATE ORDERS FLOAT TO REAL
ALTER TABLE orders ALTER COLUMN price REAL;
--same for reports
ALTER TABLE reports ALTER COLUMN price REAL;
--HolidayHomeSYS.sql 
--This script builds the database for the HolidayHomeSYS

--DROP ALL TABLES;

DROP TABLE Payments;
DROP TABLE Bookings;
DROP TABLE Tenants;
DROP TABLE Properties;
DROP TABLE TYPES;


CREATE TABLE Types(
Prop_type char(1),
Description char(15),
CONSTRAINT pk_Types PRIMARY KEY (Prop_type));

CREATE TABLE Properties
(Prop_No numeric(10) NOT NULL,
No_Beds numeric (10),
Prop_Type char(1),
Street varchar(50),
Town char(50),
County char (50),
Status char(1),
Rent numeric (10),
Garage char(3),
Garden char(3),
Constraint pk_Properties PRIMARY KEY(Prop_No),
CONSTRAINT  fk_Properties_Types FOREIGN KEY (Prop_Type) REFERENCES Types);

CREATE TABLE Tenants
(Tenant_ID numeric (10) NOT NULL,
Surname char(20),
Forename char(20),
Phone_No varchar(15),
card varchar(15),
CONSTRAINT pk_Tenants PRIMARY KEY(Tenant_ID));

CREATE TABLE Bookings
(Booking_ID numeric(10) NOT NULL,
Tenant_ID numeric(10) NOT NULL,
Prop_No numeric(10) NOT NULL,
Status char (5),
DateFrom date,
DateTo date,
Amount decimal (7,2),
CONSTRAINT pk_Bookings PRIMARY KEY(Booking_ID),
CONSTRAINT fk_Bookings_Properties FOREIGN KEY (Prop_No) REFERENCES Properties,
CONSTRAINT fk_Bookings_Tenants FOREIGN KEY (Tenant_ID) REFERENCES Tenants);

CREATE TABLE Payments
(Payment_ID numeric (10) NOT NULL,
Tenant_Id numeric(10) NOT NULL,
Date_Paid date,
Amount numeric (10),
CONSTRAINT pk_Payments PRIMARY KEY(Payment_ID),
CONSTRAINT fk_payments_bookings FOREIGN KEY (Tenant_ID) REFERENCES Tenants);




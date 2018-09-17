-- TestData
INSERT INTO Types
VALUES('H','House');

INSERT INTO Types
VALUES ('A','Apartment');

ALTER TABLE Properties
MODIFY Rent decimal (8,2);


SELECT *
FROM PROPERTIES
WHERE No_Beds = 4 AND PROP_TYPE = 'H';

SELECT *
FROM Tenants;

INSERT INTO Bookings
VALUES(1,1,1,'b',To_Date('10/03/2018','DD/MM/YYYY'),To_Date('12/03/2018','DD,MM,YYYY'),300);

INSERT INTO Bookings
VALUES(1,3,1,'16-MAR-18','18-MAR-28',300);

INSERT INTO Bookings
VALUES(1,4,1,To_Date('16/04/2018','DD/MM/YYYY'),To_Date('20/04/2018','DD,MM,YYYY'),300);

SELECT *
FROM Properties;

SELECT * from Properties p where p.PROP_NO NOT IN (SELECT DISTINCT prop_no FROM bookings bk where (bk.DATEFROM BETWEEN To_Date('14,03,2018','DD,MM,YYYY') AND To_Date('16,03,2018','DD,MM,YYYY')) OR (bk.DATETO BETWEEN To_Date('14,03,2018','DD,MM,YYYY') AND To_Date('16,03,2018','DD,MM,YYYY')) OR (bk.datefrom < To_Date('14,03,2018', 'DD,MM,YYYY') AND bk.dateto > To_Date('16,03,2018', 'DD,MM,YYYY')));


SELECT * from PROPERTIES 
where PROP_type = 'A' AND No_beds = 2;

INSERT INTO Bookings
VALUES(1,2,1,To_Date('26/03/2018','DD/MM/YYYY'),To_Date('28/03/2018','DD,MM,YYYY'),300);

SELECT * from bookings where DATEFROM = To_Date('10/MAR/2018', 'DD/MM/YYYY');

SELECT * FROM bookings where datefrom = '10-MAR-18';

DELETE FROM bookings where BOOKING_ID ='1';

SELECT * from bookings order by BOOKING_ID;

UPDATE bookings set STATUS ='B' where BOOKING_ID = '4';

ALTER TABLE Bookings
modify Status char (6);

SELECT *
from bookings
INNER JOIN tenants on bookings.TENANT_ID = tenants.tenant_ID
where bookings.status = 'B';

DELETE from bookings where prop_no = 4;
DELETE  from properties where prop_no = 4;
DELETE from payments where payment_id = 0;

update bookings
set status = 'B'
where booking_id = 9;




COMMIT;
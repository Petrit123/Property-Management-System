INSERT into Properties
VALUES(1,2,'H','main street','xxxx','kerry','a',25,'y','y');

INSERT into Properties
VALUES(2,4,'A','bridge street','tralee','kerry','a',50.5,'y','n');

INSERT into Properties
VALUES(3,1,'H','12 street','sdf','cork','a',35,'n','n');

INSERT into Properties
VALUES(4,3,'A','manor','erf','dublin','a',100,'n','y');

INSERT into Properties
VALUES(5,4,'H','sdf','killorglin','kerry','a',15,'n','n');

INSERT into Tenants
VALUES(1,'teahan','jack',123,123);

INSERT into Tenants
VALUES(2,'donoghue','mark',123,123);

INSERT into Tenants
VALUES(3,'mcinerney','jared',123,123);

INSERT into Tenants
VALUES(4,'malone','kenneth',123,123);

INSERT into Tenants
VALUES(5,'krasniqi','petrit',123,123);

INSERT into Tenants
VALUES(6,'o brien','conor',123,123);

INSERT into Tenants
VALUES(7,'herlihy','dave',123,123);

INSERT into Tenants
VALUES(8,'carey','dylan',123,123);

INSERT into Tenants
VALUES(9,'o hara','jack',123,123);

INSERT into Tenants
VALUES(10,'curran','glen',123,123);

INSERT into Bookings
VALUES(1,1,2,'C-IN',To_Date('24/04/2018','DD/MM/YYYY'),To_Date('27/04/2018','DD/MM/YYYY'),100);

INSERT into Bookings
VALUES(1,1,2,'C-IN',To_Date('24/04/2018','DD/MM/YYYY'),To_Date('27/04/2018','DD/MM/YYYY'),100);

INSERT into Bookings
VALUES(2,1,2,'B',To_Date('24/05/2018','DD/MM/YYYY'),To_Date('27/05/2018','DD/MM/YYYY'),100);

INSERT into Bookings
VALUES(3,2,3,'B',To_Date('12/06/2018','DD/MM/YYYY'),To_Date('14/06/2018','DD/MM/YYYY'),70);

INSERT into Bookings
VALUES(4,4,4,'B',To_Date('24/05/2018','DD/MM/YYYY'),To_Date('27/05/2018','DD/MM/YYYY'),100);

INSERT into Bookings
VALUES(5,5,5,'B',To_Date('24/10/2018','DD/MM/YYYY'),To_Date('30/10/2018','DD/MM/YYYY'),90);

INSERT into Bookings
VALUES(6,7,5,'C-OUT',To_Date('2/02/2018','DD/MM/YYYY'),To_Date('10/02/2018','DD/MM/YYYY'),350);

INSERT into Bookings
VALUES(7,9,4,'C-OUT',To_Date('15/01/2018','DD/MM/YYYY'),To_Date('20/01/2018','DD/MM/YYYY'),400);

INSERT into Bookings
VALUES(8,3,2,'C-OUT',To_Date('18/03/2018','DD/MM/YYYY'),To_Date('20/03/2018','DD/MM/YYYY'),500);

INSERT into Bookings
VALUES(9,2,1,'C-IN',To_Date('26/04/2018','DD/MM/YYYY'),To_Date('28/04/2018','DD/MM/YYYY'),700);

INSERT into Bookings
VALUES(10,7,5,'C-IN',To_Date('26/04/2018','DD/MM/YYYY'),To_Date('28/04/2018','DD/MM/YYYY'),400);

INSERT into PAYMENTS
VALUES(1,1,To_Date('24/04/2018','DD/MM/YYYY'),100);

INSERT into PAYMENTS
VALUES(2,2,To_Date('26/04/2018','DD/MM/YYYY'),700);

INSERT into PAYMENTS
VALUES(3,7,To_Date('26/04/2018','DD/MM/YYYY'),400);

commit;

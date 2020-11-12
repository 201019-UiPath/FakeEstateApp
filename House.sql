-- drop table housefeatures;
-- drop table houses;
-- drop table features;


CREATE TABLE Houses (
    id serial primary key,
	bedrooms int,
	bathrooms int,
	floors int,
	location varchar(50),
	ac bool,
	heating bool,
	price decimal(10,2)
);

Create TABLE features(
	id serial primary key,
	description varchar(100),
	fee decimal(10,2)
);


Create TABLE housefeatures(
	id serial primary key,
	houseid int references houses (id),
	featureid int references features (id)
);


Insert into Houses (bedrooms, bathrooms, floors, location, ac, heating, price) values 
(2,2,2,'Boston', true, true, 500000.00);

Insert into features(description, fee) values 
('Pool', 100.00),
('Basement', 150.00),
('Backyard', 200.00),
('Attic', 150.00);

insert into housefeatures (houseid, featureid) values
(1,1),
(1,3);

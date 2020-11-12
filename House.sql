CREATE TABLE House (
    id serial primary key,
	bedrooms int,
	bathrooms int,
	floors int,
	location varchar(50),
	ac bool,
	heating bool,
	price decimal
);

Create TABLE features(
	id serial primary key,
	description varchar(100),
	fee decimal
);


Create TABLE housefeatures(
	id serial primary key,
	houseid int references house (id),
	featureid int references features (id)
);

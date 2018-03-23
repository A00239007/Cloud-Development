Drop table if exists Newspaper
create table Newspaper(id int IDENTITY, name varchar(50), price float, country_of_delivery varchar(50))

insert into Newspaper values('The Irish Times',2.5,'Ireland')
insert into Newspaper values('Wall Street Journal', 2.0, 'USA')
insert into Newspaper values('The Sun', 1.5, 'United Kingdom')
insert into Newspaper values('The Mirror', 1.0, 'United Kingdom')

select * from Newspaper

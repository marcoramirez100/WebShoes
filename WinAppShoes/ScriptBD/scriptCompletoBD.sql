--create database bdshoes
--go

create table dbo.stores
(
	id smallint not null identity(1,1),
	name varchar(50) not null,
	address varchar(150) not null,
)
alter table dbo.stores add constraint PK_stores primary key(id)
go

--set identity_insert dbo.stores on
--insert into dbo.stores(id,name,address) values(1,'SUCURSAL LZC','AV. HEROICA ESC. NAV. MILITAR #21, CENTRO, 60950')
--insert into dbo.stores(id,name,address) values(2,'SUCURSAL GDL','CALLE COLEGIO MILITAR #456, LA ORILLA, 60951')
--insert into dbo.stores(id,name,address) values(3,'SUCURSAL CDMX','CALLE LAGO ATHABASCA #143, CENTRO, 60952')
--insert into dbo.stores(id,name,address) values(4,'SUCURSAL MOR','AV. MORELOS MUJICA #124, CENTRO, 60953')
--set identity_insert dbo.stores on


create table dbo.articles
(
	id int not null identity(1,1),
	name varchar(50) not null,
	description varchar(150) not null,
	price decimal(10,2) not null,
	total_in_shelf int not null,
	total_in_vault int not null,
	store_id smallint not null,
)
alter table dbo.articles add constraint PK_articles primary key(id)
alter table dbo.articles add constraint FK_articles_stores foreign key(store_id)
references dbo.stores(id)

set identity_insert dbo.articles on
insert into dbo.articles(id,name,description,price,total_in_shelf,total_in_vault,store_id) values(1,'Traje Aldo Conti Verde MOD100','Traje de Lana Aldo Conti, color Verde',10050,3,5,1)
insert into dbo.articles(id,name,description,price,total_in_shelf,total_in_vault,store_id) values(2,'Traje Aldo Conti Beige MOD234','Traje de Lana Aldo Conti, Color Beige ',12080,3,5,2)
insert into dbo.articles(id,name,description,price,total_in_shelf,total_in_vault,store_id) values(3,'Traje Aldo Conti Negro-Azul MOD569','Traje de Tergal Aldo Conti, Color Negro-Azul',20000,3,5,3)
insert into dbo.articles(id,name,description,price,total_in_shelf,total_in_vault,store_id) values(4,'Vestido de seda color rosa palo','Vestido de seda color rosa linea A',890,3,5,4)
set identity_insert dbo.articles off

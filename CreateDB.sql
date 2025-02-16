create table SK.Roles (
	Rolename varchar(50) not null primary key
)

create table SK.Users (
	Username varchar(50) not null primary key,
	Fullname nvarchar(100) not null,
	Email varchar(50) not null
)

create table SK.UserRoles (
	Username varchar(50) not null,
	Rolename varchar(50) not null,
	primary key(Username, Rolename),
	foreign key(Username) references SK.Users(Username),
	foreign key(Rolename) references SK.Roles(Rolename)
)
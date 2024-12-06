create table RequestStatuses (
	RequestStatusID int primary key,
	Status nvarchar(20)
)

create table TechTypes (
	TechTypeID int primary key,
	TechType nvarchar(30)
)

create table UserTypes (
	UserTypeID int primary key,
	UserTypeName nvarchar (25)
)

create table Users (
	UserID int primary key,
	Surname nvarchar(40),
	Name nvarchar(40),
	LastName nvarchar(40),
	PhoneNumber nvarchar(12),
	UserLogin nvarchar(40),
	UserPassword nvarchar(40),
	UserTypeID int foreign key references UserTypes(UserTypeID)
)


create table Requests (
	RequestID int primary key,
	StartDate Date,
	TechTypeID int foreign key references TechTypes(TechTypeID),
	TechModel text,
	Description text,
	RequestStatusID int foreign key references RequestStatuses(RequestStatusID),
	ComplitionDate date,
	MasterID int foreign key references Users(UserID),
	ClientID int foreign key references Users(UserID)
)

create table Comments (
	CommentID int primary key,
	Message text,	
	UserID int foreign key references Users(UserID),
	RequestID int foreign key references Requests(RequestID)
) 

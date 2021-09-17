create table Gadget
(
    Gadget_id int identity primary key,
    Name nvarchar(255) not null,
    Vendor_id int,
    Brand_id int
);

create table Vendor
(
    Vendor_id int  identity primary key,
    Name nvarchar(255) not null,
);

create table Brand
(
    Brand_id int  identity primary key,
    Name nvarchar(255) not null,
);

alter table Gadget add foreign key (Vendor_id) references Vendor(Vendor_id);
alter table Gadget add foreign key (Brand_id) references Brand(Brand_id);

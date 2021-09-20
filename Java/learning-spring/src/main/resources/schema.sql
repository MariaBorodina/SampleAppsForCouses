create table if not exists Gadget(
    Gadget_id int auto_increment primary key,
    GadgetName nvarchar(255) not null,
    Vendor_id int,
    Brand_id int
);

create table if not exists Vendor(
    Vendor_id int auto_increment primary key,
    VendorName nvarchar(255) not null
);

create table if not exists Brand(
    Brand_id int auto_increment primary key,
    BrandName nvarchar(255) not null
);

alter table Gadget add foreign key (Vendor_id) references Vendor(Vendor_id);
alter table Gadget add foreign key (Brand_id) references Brand(Brand_id);

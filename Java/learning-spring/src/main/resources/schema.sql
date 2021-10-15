create table if not exists Gadget(
    Gadget_id serial primary key,
    GadgetName varchar(255) not null,
    vendor_id int,
    brand_id int
);

create table if not exists Vendor(
    vendor_id serial primary key,
    VendorName varchar(255) not null
);

create table if not exists Brand(
    brand_id serial primary key,
    BrandName varchar(255) not null
);

alter table Gadget add foreign key (vendor_id) references Vendor(vendor_id);
alter table Gadget add foreign key (brand_id) references Brand(brand_id);

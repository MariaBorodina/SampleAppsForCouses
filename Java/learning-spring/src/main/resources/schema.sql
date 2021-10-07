create table if not exists Gadget(
    Gadget_id int auto_increment primary key,
    GadgetName nvarchar(255) not null,
    vendor_id int,
    brand_id int
);

create table if not exists Vendor(
    vendor_id int auto_increment primary key,
    VendorName nvarchar(255) not null
);

create table if not exists Brand(
    brand_id int auto_increment primary key,
    BrandName nvarchar(255) not null
);

alter table Gadget add foreign key (vendor_id) references Vendor(vendor_id);
alter table Gadget add foreign key (brand_id) references Brand(brand_id);

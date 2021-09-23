package com.mariaborodina.java.learningspring.data.entity;

import javax.persistence.*;

@Entity
@Table(name="Gadget")
public class Gadget {
    @Id
    @Column(name = "Gadget_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @Column(name = "GadgetName")
    private String vname;

    @Column(name="Vendor_id")
    private int VendorId;

    @Column(name="Brand_id")
    private int BrandId;

    public Gadget() {
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getVname() {
        return vname;
    }

    public void setVname(String vname) {
        this.vname = vname;
    }

    public int getBrandId() {
        return BrandId;
    }

    public void setBrandId(int brandId) {
        BrandId = brandId;
    }

    public int getVendorId() {
        return VendorId;
    }

    public void setVendorId(int vendorId) {
        VendorId = vendorId;
    }
}
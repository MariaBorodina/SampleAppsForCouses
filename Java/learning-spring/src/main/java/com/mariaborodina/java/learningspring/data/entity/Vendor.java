package com.mariaborodina.java.learningspring.data.entity;

import javax.persistence.*;

@Entity
@Table(name="Vendor")
public class Vendor {
    @Id
    @Column(name = "Vendor_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @Column(name = "VendorName")
    private String name;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
}

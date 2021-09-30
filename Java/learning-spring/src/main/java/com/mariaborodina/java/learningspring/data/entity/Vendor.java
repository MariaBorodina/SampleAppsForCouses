package com.mariaborodina.java.learningspring.data.entity;

import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;

@Entity
@Table(name="Vendor")
public class Vendor {
    @Id
    @Column(name = "Vendor_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Getter
    @Setter
    private int id;

    @Column(name = "VendorName")
    @Getter
    @Setter
    private String vname;

}

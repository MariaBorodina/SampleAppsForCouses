package com.mariaborodina.java.learningspring.data.entity;

import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.Collection;

@Entity
@Table(name="Vendor")
@Getter
@Setter
public class Vendor {
    @Id
    @Column(name = "vendor_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @Column(name = "VendorName")
    private String vname;

    @OneToMany(mappedBy = "vendor", fetch = FetchType.EAGER)
    private Collection<Gadget> goods;


}

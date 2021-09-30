package com.mariaborodina.java.learningspring.data.entity;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;

@Entity
@Table(name="Gadget")
public class Gadget {
    @Id
    @Column(name = "Gadget_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Getter
    @Setter
    private int id;

    @Column(name = "GadgetName")
    @Getter
    @Setter
    private String vname;

    @Column(name="Vendor_id")
    @JsonProperty("vendor_id")
    @Getter
    @Setter
    private int vendorId;

    @Column(name="Brand_id")
    @JsonProperty("brand_id")
    @Getter
    @Setter
    private int brandId;

    public Gadget() {
    }

}
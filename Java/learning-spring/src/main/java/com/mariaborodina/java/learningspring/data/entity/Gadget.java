package com.mariaborodina.java.learningspring.data.entity;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.*;

import javax.persistence.*;

@Entity
@Table(name="Gadget")
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class Gadget {
    @Id
    @Column(name = "Gadget_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    @Column(name = "GadgetName")
    private String vname;


/*
    @ManyToOne(optional=false, cascade=CascadeType.ALL)
    @JoinColumn(name="vendor_id")
    private Vendor vendor;
    @ManyToOne(optional=false, cascade=CascadeType.ALL)
        @JoinColumn(name="brand_id")
        private Brand brand;*/

    @Column(name="Vendor_id")
    private Integer vendorId;

    @Column(name="Brand_id")
    private Integer brandId;



}
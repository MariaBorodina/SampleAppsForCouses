package com.mariaborodina.java.learningspring.data.entity;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.*;
import org.modelmapper.ModelMapper;

import javax.persistence.*;

@Entity
@Table(name="Gadget")
@Getter
@Setter
@NoArgsConstructor
public class Gadget {
    @Id
    @Column(name = "Gadget_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;

    @Column(name = "GadgetName")
    private String vname;


    @ManyToOne(optional=true, cascade=CascadeType.ALL)
    @JoinColumn(name="vendor_id",insertable=false, updatable=false)
    private Vendor vendor;

    @ManyToOne(optional=true, cascade=CascadeType.ALL)
    @JoinColumn(name="brand_id",insertable=false, updatable=false)
    private Brand brand;

    @Column(name="Vendor_id", insertable=true)
    private Integer vendorId;

    @Column(name="Brand_id", insertable=true)
    private Integer brandId;

}
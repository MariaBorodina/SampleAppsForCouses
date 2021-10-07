package com.mariaborodina.java.learningspring.data.entity;

import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.Collection;

@Entity
@Table(name="Brand")
@Getter
@Setter
public class Brand {
    @Id
    @Column(name = "Brand_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @Column(name = "BrandName")
    private String vname;

    @OneToMany(mappedBy = "vendor", fetch = FetchType.EAGER)
    private Collection<Gadget> goods;

}
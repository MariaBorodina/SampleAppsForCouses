package com.mariaborodina.java.learningspring.data.entity;

import lombok.AccessLevel;
import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;

@Entity
@Table(name="Brand")
public class Brand {
    @Id
    @Column(name = "Brand_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private int id;

    @Column(name = "BrandName")
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private String vname;

}
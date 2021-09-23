package com.mariaborodina.java.learningspring.data.entity;

import javax.persistence.*;

@Entity
@Table(name="Brand")
public class Brand {
    @Id
    @Column(name = "Brand_id")
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;

    @Column(name = "BrandName")
    private String vname;

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
}
package com.mariaborodina.java.learningspring.business.domain;

import com.mariaborodina.java.learningspring.data.entity.Brand;
import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@AllArgsConstructor
@Getter
@Setter
public class BrandModel {

    private Integer brandId;
    private String brandName;

    public BrandModel(Brand brand) {
        this.brandId = brand.getId();
        this.brandName = brand.getVname();
    }
}

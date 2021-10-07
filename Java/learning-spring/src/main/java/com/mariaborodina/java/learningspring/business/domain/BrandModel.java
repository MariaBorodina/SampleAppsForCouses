package com.mariaborodina.java.learningspring.business.domain;

import com.mariaborodina.java.learningspring.data.entity.Brand;
import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@AllArgsConstructor
public class BrandModel {
    @Getter
    @Setter
    private Integer brandId;
    @Getter
    @Setter
    private String brandName;

    public BrandModel(Brand brand) {
        this.brandId = brand.getId();
        this.brandName = brand.getVname();
    }
}

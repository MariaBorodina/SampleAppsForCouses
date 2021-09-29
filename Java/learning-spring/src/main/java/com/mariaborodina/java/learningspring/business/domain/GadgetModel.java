package com.mariaborodina.java.learningspring.business.domain;

import lombok.Getter;
import lombok.Setter;

public class GadgetModel {
    @Getter
    @Setter
    private int gadgetId;
    @Getter
    @Setter
    private String gadgetName;

    @Getter
    @Setter
    private int brandId;
    @Getter
    @Setter
    private String brandName;

    @Getter
    @Setter
    private int vendorId;
    @Getter
    @Setter
    private String vendorName;


    public GadgetModel(int gadgetId, String gadgetName, int brandId, String brandName, int vendorId, String vendorName) {
        this.gadgetId = gadgetId;
        this.gadgetName = gadgetName;
        this.brandId = brandId;
        this.brandName = brandName;
        this.vendorId = vendorId;
        this.vendorName = vendorName;
    }
}

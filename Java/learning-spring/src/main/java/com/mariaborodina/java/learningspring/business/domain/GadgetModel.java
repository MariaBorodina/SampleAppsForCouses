package com.mariaborodina.java.learningspring.business.domain;

import lombok.Getter;
import lombok.Setter;

public class GadgetModel {
    @Getter
    @Setter
    private int id;

    @Getter
    @Setter
    private String gadgetName;

    @Getter
    @Setter
    private String brandName;

    @Getter
    @Setter
    private String vendorName;

    public GadgetModel(int id, String gadgetName, String brandName, String vendorName) {
        this.id = id;
        this.gadgetName = gadgetName;
        this.brandName = brandName;
        this.vendorName = vendorName;
    }

}

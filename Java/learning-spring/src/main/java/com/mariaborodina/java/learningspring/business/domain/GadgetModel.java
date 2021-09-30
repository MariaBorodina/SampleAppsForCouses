package com.mariaborodina.java.learningspring.business.domain;

import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@AllArgsConstructor
public class GadgetModel {
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private int gadgetId;
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private String gadgetName;

    @Getter
    @Setter(AccessLevel.PUBLIC)
    private BrandModel brand;

    @Getter
    @Setter(AccessLevel.PUBLIC)
    private VendorModel vendor;

}

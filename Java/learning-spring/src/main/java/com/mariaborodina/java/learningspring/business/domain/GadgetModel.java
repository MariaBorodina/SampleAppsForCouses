package com.mariaborodina.java.learningspring.business.domain;

import lombok.*;

@AllArgsConstructor
@NoArgsConstructor
public class GadgetModel {
    @Getter
    @Setter
    private Integer gadgetId;
    @Getter
    @Setter
    private String gadgetName;

    @Getter
    @Setter
    private BrandModel brand;

    @Getter
    @Setter
    private VendorModel vendor;

}

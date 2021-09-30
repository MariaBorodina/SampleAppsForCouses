package com.mariaborodina.java.learningspring.business.domain;

import com.mariaborodina.java.learningspring.data.entity.Vendor;
import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.Setter;

@AllArgsConstructor
public class VendorModel {
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private int vendorId;
    @Getter
    @Setter(AccessLevel.PACKAGE)
    private String vendorName;

    public VendorModel(Vendor vendor) {
        this.vendorId = vendor.getId();
        this.vendorName = vendor.getVname();
    }
}

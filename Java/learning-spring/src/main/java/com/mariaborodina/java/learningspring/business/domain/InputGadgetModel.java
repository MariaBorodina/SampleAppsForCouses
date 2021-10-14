package com.mariaborodina.java.learningspring.business.domain;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Getter;
import lombok.Setter;


@Getter
@Setter
public class InputGadgetModel {

     private String vname;

    @JsonProperty("vendor_id")
    private Integer vendorId;

    @JsonProperty("brand_id")
    private Integer brandId;
}

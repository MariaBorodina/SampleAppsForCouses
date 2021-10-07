package com.mariaborodina.java.learningspring.business.domain;

import com.fasterxml.jackson.annotation.JsonProperty;
import lombok.Getter;
import lombok.Setter;
import org.springframework.lang.Nullable;

import javax.persistence.Column;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Getter
@Setter
public class InputGadgetModel {
    @Nullable
    private Integer id;

     private String vname;

    @JsonProperty("vendor_id")
    private Integer vendorId;

    @JsonProperty("brand_id")
    private Integer brandId;
}

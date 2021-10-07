package com.mariaborodina.java.learningspring.business.service;

import lombok.Data;

@Data
public class GadgetCriteria
{
    private Integer brandId;
    private String brand;
    private Integer vendorId;
    private String vendor;
    private Integer gadgetId;
    private String gadget;
}
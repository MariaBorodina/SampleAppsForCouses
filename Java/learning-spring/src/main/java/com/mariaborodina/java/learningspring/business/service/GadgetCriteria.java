package com.mariaborodina.java.learningspring.business.service;

import lombok.Data;

@Data
public class GadgetCriteria
{
    private int brandId;
    private String brand;
    private int vendorId;
    private String vendor;
    private int gadgetId;
    private String gadget;
}
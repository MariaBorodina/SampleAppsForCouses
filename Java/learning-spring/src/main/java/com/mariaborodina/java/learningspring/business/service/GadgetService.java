package com.mariaborodina.java.learningspring.business.service;

import com.mariaborodina.java.learningspring.data.entity.Gadget;
import com.mariaborodina.java.learningspring.data.repository.BrandRepository;
import com.mariaborodina.java.learningspring.data.repository.GadgetRepository;
import com.mariaborodina.java.learningspring.data.repository.VendorRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class GadgetService {
    private final GadgetRepository gadgetRepository;
    private final VendorRepository vendorRepository;
    private final BrandRepository brandRepository;

    @Autowired
    public GadgetService(GadgetRepository gadgetRepository, VendorRepository vendorRepository, BrandRepository brandRepository) {
        this.gadgetRepository = gadgetRepository;
        this.vendorRepository = vendorRepository;
        this.brandRepository = brandRepository;
    }

    public List<Gadget> getGadgets(){
        return null;
    }
}

package com.mariaborodina.java.learningspring.business.service;

import com.mariaborodina.java.learningspring.business.domain.BrandModel;
import com.mariaborodina.java.learningspring.business.domain.GadgetModel;
import com.mariaborodina.java.learningspring.business.domain.VendorModel;
import com.mariaborodina.java.learningspring.data.entity.Gadget;
import com.mariaborodina.java.learningspring.data.repository.BrandRepository;
import com.mariaborodina.java.learningspring.data.repository.GadgetRepository;
import com.mariaborodina.java.learningspring.data.repository.VendorRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
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

    public List<GadgetModel> getGadgets(){
        var gadgets= gadgetRepository.findAll();

        var res = new ArrayList<GadgetModel>();
        gadgets.iterator().forEachRemaining(gadget -> {
            var vendor = vendorRepository.findById(gadget.getVendorId());
            var brand = brandRepository.findById(gadget.getBrandId());

            res.add(
                    new GadgetModel(
                            gadget.getId(),
                            gadget.getVname(),
                            new BrandModel(brand.get()),
                            new VendorModel(vendor.get())));
        });

        return res;
    }

    public List<GadgetModel> getGadgetsByBrand(String brandName){
        var brands = brandRepository.findBrandByvname(brandName);
        if(brands == null || !brands.iterator().hasNext())
            return null;

        var brand = brands.iterator().next();
        var gadgets= gadgetRepository.findGadgetByBrandId(brand.getId());
        if(gadgets == null)
            return null;

        var res = new ArrayList<GadgetModel>();
        gadgets.iterator().forEachRemaining(gadget -> {
                var vendor = vendorRepository.findById(gadget.getVendorId());

                res.add(
                    new GadgetModel(
                            gadget.getId(),
                            gadget.getVname(),
                            new BrandModel(brand),
                            new VendorModel(vendor.get())));
        });

        return res;
    }

}

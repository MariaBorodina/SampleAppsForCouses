package com.mariaborodina.java.learningspring.business.service;

import com.mariaborodina.java.learningspring.business.domain.GadgetModel;
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
        return null;
    }

    public List<GadgetModel> getGadgetsByBrand(String brandName){
        var brands = brandRepository.findBrandByvname(brandName);
        if(brands == null || !brands.iterator().hasNext())
            return null;

        var brandId = brands.iterator().next().getId();
        var gadgets= gadgetRepository.findGadgetByBrandId(brandId);
        if(gadgets == null)
            return null;

        var res = new ArrayList<GadgetModel>();
        gadgets.iterator().forEachRemaining(gadget -> {
                var vendor = vendorRepository.findById(gadget.getVendorId());
                var vendorName = vendor != null ? vendor.get().getVname() : "";

                res.add(
                    new GadgetModel(
                            gadget.getId(),
                            gadget.getVname(),
                            brandId,
                            brandName,
                            vendor.get().getId(),
                            vendorName));
        });

        return res;
    }

}

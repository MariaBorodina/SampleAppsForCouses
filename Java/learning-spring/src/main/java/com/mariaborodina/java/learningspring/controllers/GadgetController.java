package com.mariaborodina.java.learningspring.controllers;

import com.mariaborodina.java.learningspring.business.domain.BrandModel;
import com.mariaborodina.java.learningspring.business.domain.GadgetModel;
import com.mariaborodina.java.learningspring.business.domain.InputGadgetModel;
import com.mariaborodina.java.learningspring.business.domain.VendorModel;
import com.mariaborodina.java.learningspring.business.service.GadgetCriteria;
import com.mariaborodina.java.learningspring.business.service.GadgetService;
import com.mariaborodina.java.learningspring.data.entity.Gadget;
import com.mariaborodina.java.learningspring.data.repository.GadgetRepository;
import lombok.extern.java.Log;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/gadgets")
@Log
public class GadgetController
{
    @Autowired
    private GadgetRepository gadgetRepository;
    @Autowired
    private GadgetService gadgetService;

    @GetMapping
    public Iterable<GadgetModel> getGadgets(GadgetCriteria criteria)
    {
        return gadgetService.getGadgetsByCriteria(criteria);
    }

    @GetMapping("/brand/{name}")
    public Iterable<GadgetModel> getGadgetsByBrandName(@PathVariable String name)
    {
        return gadgetService.getGadgetsByBrand(name);
    }

    @PostMapping
    public void post(@RequestBody InputGadgetModel gadget)
    {
        gadgetService.save(gadget);
    }

    private void print(Iterable<GadgetModel> list)
    {
        log.info(String.format("Gadgets: has some values: %b", list.iterator().hasNext()));
    }
}



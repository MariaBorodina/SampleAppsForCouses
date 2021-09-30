package com.mariaborodina.java.learningspring.controllers;

import com.mariaborodina.java.learningspring.business.domain.GadgetModel;
import com.mariaborodina.java.learningspring.business.service.GadgetService;
import com.mariaborodina.java.learningspring.data.entity.Gadget;
import com.mariaborodina.java.learningspring.data.repository.GadgetRepository;
import lombok.extern.java.Log;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.logging.Logger;

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
    public Iterable<GadgetModel> getGadgets()
    {
        Iterable<GadgetModel> res;
        res = gadgetService.getGadgets();

        return  res;
    }

    @GetMapping("/{brandName}")
    public Iterable<GadgetModel> getGadgetsByBrand(@PathVariable String brandName)
    {
        Iterable<GadgetModel> res;
        res = gadgetService.getGadgetsByBrand(brandName);

        return  res;
    }

    @PostMapping
    public void post(@RequestBody Gadget model)
    {
        gadgetRepository.save(model);
    }

    private void print(Iterable<GadgetModel> list)
    {
        log.info(String.format("Gadgets: has some values: %b", list.iterator().hasNext()));
    }
}



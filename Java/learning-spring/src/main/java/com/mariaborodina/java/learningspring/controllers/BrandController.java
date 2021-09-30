package com.mariaborodina.java.learningspring.controllers;


import com.mariaborodina.java.learningspring.data.entity.Brand;
import com.mariaborodina.java.learningspring.data.repository.BrandRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.logging.Logger;

@RestController
@RequestMapping("/brands")
public class BrandController
{
    @Autowired
    private BrandRepository brandRepository;

    @GetMapping
    public Iterable<Brand> getBrands()
    {
        Iterable<Brand> res;
        res = brandRepository.findAll();

        print(res);

        return  res;
    }

    @PostMapping
    public void post(@RequestBody Brand model)
    {
        brandRepository.save(model);
    }

    private void print(Iterable<Brand> list)
    {
        String msg = String.format("Brands: has some values: %b", list.iterator().hasNext());
        Logger.getLogger(this.getClass().getName()).info(msg);
    }
}
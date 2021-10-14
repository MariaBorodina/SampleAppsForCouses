package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Brand;

public interface SampleRepository {
    public Iterable<Brand> getBrandsCustom(String vname);
}

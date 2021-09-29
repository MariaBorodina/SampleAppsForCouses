package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Brand;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface BrandRepository extends CrudRepository<Brand, Integer> {

    Iterable<Brand> findBrandByvname(String vname);
}

package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Brand;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

public class SampleRepositoryImpl implements SampleRepository {
    @PersistenceContext
    private EntityManager entityManager;


    @Override
    public Iterable<Brand> getBrandsCustom(String vname) {
        return this.entityManager.
        createQuery("SELECT * FROM Brand u WHERE u.brandname like '"+vname+"'").
        getResultList();

    }
}

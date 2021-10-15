package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Brand;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.transaction.Transactional;

@Repository
@Transactional
public interface BrandRepository extends CrudRepository<Brand, Integer>, SampleRepository {

    Iterable<Brand> findBrandByVname(String vname);

    @Query( value = "SELECT * FROM Brand u WHERE u.brandname = 'brand2'",
            nativeQuery = true)
    Iterable<Brand> findWhatINeedByName(String vname);
}

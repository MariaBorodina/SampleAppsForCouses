package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Gadget;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;
import org.springframework.data.jpa.repository.JpaRepository;

@Repository
public interface GadgetRepository extends JpaRepository<Gadget, Integer> {

    Iterable<Gadget> findGadgetByBrandId(int brandid);
}

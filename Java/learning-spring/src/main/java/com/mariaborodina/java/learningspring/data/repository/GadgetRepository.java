package com.mariaborodina.java.learningspring.data.repository;

import com.mariaborodina.java.learningspring.data.entity.Gadget;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface GadgetRepository extends CrudRepository<Gadget, Integer> {

}

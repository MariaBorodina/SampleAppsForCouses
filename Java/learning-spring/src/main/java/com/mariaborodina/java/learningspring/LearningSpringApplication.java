package com.mariaborodina.java.learningspring;

import com.mariaborodina.java.learningspring.business.domain.GadgetModel;
import com.mariaborodina.java.learningspring.business.service.GadgetService;
import com.mariaborodina.java.learningspring.data.entity.Brand;
import com.mariaborodina.java.learningspring.data.entity.Gadget;
import com.mariaborodina.java.learningspring.data.entity.Vendor;
import com.mariaborodina.java.learningspring.data.repository.BrandRepository;
import com.mariaborodina.java.learningspring.data.repository.GadgetRepository;
import com.mariaborodina.java.learningspring.data.repository.VendorRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.*;

import java.util.logging.Logger;

@SpringBootApplication
public class LearningSpringApplication {

	public static void main(String[] args) {
		SpringApplication.run(LearningSpringApplication.class, args);
	}




}

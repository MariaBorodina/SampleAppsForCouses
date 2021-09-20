package com.mariaborodina.java.learningspring;

import com.mariaborodina.java.learningspring.data.entity.Vendor;
import com.mariaborodina.java.learningspring.data.repository.VendorRepository;
import org.aspectj.weaver.Iterators;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.logging.Logger;

@SpringBootApplication
public class LearningSpringApplication {

	public static void main(String[] args) {
		SpringApplication.run(LearningSpringApplication.class, args);
	}


	@RestController
	@RequestMapping("/vendors")
	public class VendorController
	{
		@Autowired
		private VendorRepository vendorRepository;

		@GetMapping
		public Iterable<Vendor> getVendors()
		{
			Iterable<Vendor> res =  vendorRepository.findAll();

			printVendors(res);

			return  res;
		}

		private void printVendors(Iterable<Vendor> vendors)
		{
			String msg = String.format("Vendors: has some values: %b", vendors.iterator().hasNext());
			Logger.getLogger(this.getClass().getName()).info(msg);
		}
	}

}

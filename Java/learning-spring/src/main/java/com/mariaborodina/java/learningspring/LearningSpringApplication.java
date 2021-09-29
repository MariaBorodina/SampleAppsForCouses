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


	@RestController
	@RequestMapping("/vendors")
	public class VendorController
	{
		@Autowired
		private VendorRepository vendorRepository;

		@GetMapping
		public Iterable<Vendor> getVendors()
		{
			Iterable<Vendor> res;
			res = vendorRepository.findAll();

			printVendors(res);

			return  res;
		}

		@PostMapping
		public void postVendors(@RequestBody Vendor vendor)
		{
			vendorRepository.save(vendor);
		}

		private void printVendors(Iterable<Vendor> vendors)
		{
			String msg = String.format("Vendors: has some values: %b", vendors.iterator().hasNext());
			Logger.getLogger(this.getClass().getName()).info(msg);
		}
	}


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


	@RestController
	@RequestMapping("/gadgets")
	public class GadgetController
	{
		@Autowired
		private GadgetRepository gadgetRepository;
		@Autowired
		private GadgetService gadgetService;

		@GetMapping
		public Iterable<Gadget> getGadgets()
		{
			Iterable<Gadget> res;
			res = gadgetRepository.findAll();

			print(res);

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

		private void print(Iterable<Gadget> list)
		{
			String msg = String.format("Gadgets: has some values: %b", list.iterator().hasNext());
			Logger.getLogger(this.getClass().getName()).info(msg);
		}
	}

}

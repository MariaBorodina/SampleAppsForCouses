package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Intefaces.TypedEventLogger;
import com.mb.CoffeeSpace.Models.Event;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;

import java.io.IOException;

public class DBLogger extends TypedEventLogger {
    @Autowired
    JdbcTemplate jdbcTemplate;

    public DBLogger(JdbcTemplate jdbcTemplate){
        this.jdbcTemplate = jdbcTemplate;
    }

    @Override
    public void logEvent(Event event) throws IOException {

    }
}

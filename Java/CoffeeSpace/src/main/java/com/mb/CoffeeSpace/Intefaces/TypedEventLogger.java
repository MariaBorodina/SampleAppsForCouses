package com.mb.CoffeeSpace.Intefaces;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Models.Event;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.ApplicationContext;

import java.io.IOException;
import java.text.DateFormat;
import java.util.Date;
import java.util.Map;

public abstract class TypedEventLogger implements EventLogger {
    @Autowired
    ApplicationContext context;


    @Override
    public void log(String message) throws IOException {
        log(null, message);
    }

    public void info(String message) throws IOException {
        log(EventType.INFO, message);
    }

    public void error(String message) throws IOException {
        log(EventType.ERROR, message);
    }

     public void log(EventType eventType, String message) throws IOException{
         logEvent(context.getBean(Event.class).setEventType(eventType).setMessage(message));
     }
}

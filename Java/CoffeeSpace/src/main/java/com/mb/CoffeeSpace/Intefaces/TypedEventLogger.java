package com.mb.CoffeeSpace.Intefaces;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Models.Event;
import org.springframework.context.ApplicationContext;

import java.io.IOException;
import java.text.DateFormat;
import java.util.Date;

public interface TypedEventLogger extends EventLogger {
    default void info(String message) throws IOException {
        log(EventType.INFO, message);
    }

    default void error(String message) throws IOException {
        log(EventType.ERROR, message);
    }

     void log(EventType eventType, String message) throws IOException;
}

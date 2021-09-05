package com.mb.CoffeeSpace.Intefaces;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Models.Event;
import org.springframework.context.ApplicationContext;

import java.io.IOException;
import java.text.DateFormat;
import java.util.Date;

public interface TypedEventLogger extends EventLogger {
    default void info(String message) throws IOException {
        logEvent(new Event(EventType.INFO, new Date(), DateFormat.getDateTimeInstance()).setMessage(message));
    }

    default void error(String message) throws IOException {
        logEvent(new Event(EventType.ERROR, new Date(), DateFormat.getDateTimeInstance()).setMessage(message));
    }
}

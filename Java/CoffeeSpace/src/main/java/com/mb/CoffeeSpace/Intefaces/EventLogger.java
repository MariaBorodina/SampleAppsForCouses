package com.mb.CoffeeSpace.Intefaces;

import com.mb.CoffeeSpace.Models.Event;

import java.io.IOException;

public interface EventLogger {
    void log(String message) throws IOException;
    default void logEvent(Event event) throws IOException
    {
        log(event.toString());
    }

}

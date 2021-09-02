package com.mb.CoffeeSpace.Intefaces;

import com.mb.CoffeeSpace.Models.Event;

public interface EventLogger {
    void log(String message);
    void logEvent(Event event);
}

package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Models.Event;

public class ConsoleLogger implements EventLogger {

    public void log(String message) {
        System.out.println(message);
    }

}

package com.mb.CoffeeSpace;

import com.mb.CoffeeSpace.Intefaces.EventLogger;

public class ConsoleLogger implements EventLogger {
    public void log(String message) {
        System.out.println(message);
    }
}

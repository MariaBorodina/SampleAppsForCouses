package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Intefaces.EventLogger;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.context.annotation.Lazy;
import org.springframework.stereotype.Component;

@Component("eventLogger")
@Lazy
public class ConsoleLogger implements EventLogger {

    public void log(String message) {
        System.out.println(message);
    }

}

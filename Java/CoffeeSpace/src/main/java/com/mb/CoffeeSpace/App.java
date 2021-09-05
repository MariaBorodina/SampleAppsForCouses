package com.mb.CoffeeSpace;


import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Intefaces.TypedEventLogger;
import com.mb.CoffeeSpace.Models.CoffeeKind;
import com.mb.CoffeeSpace.Models.Event;
import com.mb.CoffeeSpace.Services.CacheFileLogger;
import com.mb.CoffeeSpace.Services.ConsoleLogger;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ConfigurableApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import java.awt.*;
import java.io.IOException;
import java.text.DateFormat;
import java.util.Date;

public class App {
    //static EventLogger logger = new ConsoleLogger();
    static TypedEventLogger logger;
    private static ApplicationContext ctx;

    public static void main(String[] args) throws IOException {
        ctx = new ClassPathXmlApplicationContext("spring.xml");
        var app = ctx.getBean(App.class);

        try {
            app.action();
        } catch (IOException ioe) {
            System.out.println("Woops! IOException.");
            logger.error("Woops! IOException.");

//            logger.logEvent(ctx.getBean(Event.class, EventType.ERROR, new Date(), DateFormat.getDateTimeInstance())
//                    .setMessage("Woops! IOException."));
        }

        ((ConfigurableApplicationContext)ctx).close();
    }

    public App(CoffeeKind coffeeKind, EventLogger eventLogger) throws IOException {
        logger = (TypedEventLogger) eventLogger;

        logger.info("App run: " + new Date().toString());
        logger.log(coffeeKind.getName() + ": id = " + coffeeKind.getId());
    }

    void action() throws IOException {

        CoffeeKind kinda1 = new CoffeeKind("First");
//        var event = ctx.getBean(Event.class, EventType.INFO, new Date(), DateFormat.getDateTimeInstance());
//        logger.logEvent(event.setMessage( kinda1.getName() + ": id = " + kinda1.getId()));

        logger.info(kinda1.getName() + ": id = " + kinda1.getId());

        throw new IOException("aaaaaaaaaaaa");
    }
}

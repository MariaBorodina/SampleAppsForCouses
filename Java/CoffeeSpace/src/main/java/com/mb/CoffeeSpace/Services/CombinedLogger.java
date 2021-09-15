package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Intefaces.TypedEventLogger;
import com.mb.CoffeeSpace.Models.Event;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.ApplicationContext;

import java.io.IOException;
import java.text.DateFormat;
import java.util.*;

public class CombinedLogger extends TypedEventLogger {
    @Autowired
    ApplicationContext context;

    //private Collection<EventLogger> loggers;
    private Map<EventType, EventLogger> loggersMap;

    public CombinedLogger(Map<EventType, EventLogger> loggersMap) {
        //this.loggers = loggers;
        this.loggersMap = loggersMap;
    }




    @Override
    public void logEvent(Event event) throws IOException {
        var eventType = event.getEventType();
        if(eventType == null) {
            logWithConsoleLogger(event);
        }
        else if(eventType == EventType.INFO) {
            //logWithCacheFileLogger(event);
            loggersMap.get(eventType).logEvent(event);
        }
        else if(eventType == EventType.ERROR)
        {
                loggersMap.values().forEach(logger -> {
                    try {
                        logger.logEvent(event);
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                });
  /*          loggers.forEach(logger -> {
                try {
                    logger.logEvent(event);
                } catch (IOException e) {
                    e.printStackTrace();
                }
            });*/
        }
    }

    private void logWithConsoleLogger(Event e) throws IOException {
/*        if(loggers == null || !loggers.iterator().hasNext())
            return;

        for(EventLogger logger : loggers)
        {
            if(logger instanceof ConsoleLogger)
                logger.logEvent(e);
        }*/

        for(EventLogger logger : loggersMap.values())
        {
            if(logger instanceof ConsoleLogger)
                logger.logEvent(e);
        }

    }


/*    private void logWithCacheFileLogger(Event e) throws IOException {
        if(loggers == null || !loggers.iterator().hasNext())
            return;

        for(EventLogger logger : loggers)
        {
            if(logger instanceof CacheFileLogger)
                logger.logEvent(e);
        }
    }*/
}

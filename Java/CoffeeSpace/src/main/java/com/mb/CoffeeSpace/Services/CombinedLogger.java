package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Intefaces.TypedEventLogger;
import com.mb.CoffeeSpace.Models.Event;

import java.io.IOException;
import java.text.DateFormat;
import java.util.*;

public class CombinedLogger implements TypedEventLogger {
    //private Collection<EventLogger> loggers;
    private Map<EventType, EventLogger> loggersMap;

    public CombinedLogger(Map<EventType, EventLogger> loggersMap) throws IOException {
        //this.loggers = loggers;
        this.loggersMap = loggersMap;

/*        var cacheLogger = new CacheFileLogger("log3.txt", 5);
        cacheLogger.init();

        loggersMap = Map.of("Console", new ConsoleLogger(),
                "CacheToFile", cacheLogger);*/

    }

    @Override
    public void log(String message) throws IOException {
        logEvent(new Event(null, new Date(), DateFormat.getDateTimeInstance()).setMessage(message));
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

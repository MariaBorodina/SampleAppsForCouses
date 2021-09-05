package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Enums.EventType;
import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Models.Event;

import java.io.IOException;
import java.text.DateFormat;
import java.util.*;

public class CombinedLogger implements EventLogger {
    //private Collection<EventLogger> loggers;
    private Map<String, EventLogger> loggersMap;

    public CombinedLogger() throws IOException {
//        loggers = Arrays.asList(
//            new ConsoleLogger(), new CacheFileLogger("log2.txt", 1));

        var cacheLogger = new CacheFileLogger("log3.txt", 5);
        cacheLogger.init();

        loggersMap = Map.of("Console", new ConsoleLogger(),
                "CacheToFile", cacheLogger);

    }

    @Override
    public void log(String message) throws IOException {
        logEvent(new Event(null, new Date(), DateFormat.getDateTimeInstance()).setMessage(message));
    }

    @Override
    public void logEvent(Event event) throws IOException {
        var eventType = event.getEventType();
        if(eventType == null) {
            loggersMap.get("Console").logEvent(event);
        }
        else if(eventType == EventType.INFO) {
            loggersMap.get("CacheToFile").logEvent(event);
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
        }
    }
}

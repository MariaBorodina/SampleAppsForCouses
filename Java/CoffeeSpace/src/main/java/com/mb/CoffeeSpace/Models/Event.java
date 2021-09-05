package com.mb.CoffeeSpace.Models;

import com.mb.CoffeeSpace.Enums.EventType;

import java.text.DateFormat;
import java.util.Date;

public class Event {
    private static int identity = 0;

    private int id;
    private Date date;
    private DateFormat dateFormat;
    private String message;

    public EventType getEventType() {
        return eventType;
    }

    private EventType eventType;

    public Event()
    {
        id = ++identity;
    }

    public Event(EventType eventType, Date date, DateFormat dateFormat)
    {
        this();
        this.date = date;
        this.dateFormat = dateFormat;
        this.eventType = eventType;
    }

    public Event setMessage(String message)
    {
        this.message = message;
        return this;
    }

    @Override
    public String toString() {
        return "Event{" +
                "id=" + id +
                ", type=" + eventType +
                ", date=" + date +
                ", message='" + message + '\'' +
                '}';
    }
}

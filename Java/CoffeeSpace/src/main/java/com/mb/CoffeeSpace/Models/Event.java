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

    public EventType getEventType() {
        return eventType;
    }

    public Event setEventType(EventType eventType) {
        this.eventType = eventType;
        return this;
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

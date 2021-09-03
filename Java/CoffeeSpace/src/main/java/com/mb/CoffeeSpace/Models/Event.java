package com.mb.CoffeeSpace.Models;

import java.text.DateFormat;
import java.util.Date;

public class Event {
    private static int identity = 0;

    private int id;
    private Date date;
    private DateFormat dateFormat;
    private String message;

    public Event()
    {
        id = ++identity;
    }

    public Event(Date date, DateFormat dateFormat)
    {
        this();
        this.date = date;
        this.dateFormat = dateFormat;
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
                ", date=" + date +
                ", message='" + message + '\'' +
                '}';
    }
}

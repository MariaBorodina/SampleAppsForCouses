package com.mb.CoffeeSpace.Models;

public class CoffeeKind {
    private static int currentIdentity = 0;

    private String name;
    private int id;

    public String getDescription() {
        return description;
    }
    public void setDescription(String description) {
        this.description = description;
    }

    private String description;

    public String getName() { return name; }



    public int getId() {
        return id;
    }

    public CoffeeKind(String name)
    {
        this.id = ++currentIdentity;
        this.name = name;
    }
}

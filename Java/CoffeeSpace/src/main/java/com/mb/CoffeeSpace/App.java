package com.mb.CoffeeSpace;

public class App {
    static ConsoleLogger logger = new ConsoleLogger();

    public static void main(String[] args)
    {
        CoffeeKind kinda1 = new CoffeeKind("First");

        logger.log(kinda1.getName() + ": id = " + kinda1.getId());

    }
}

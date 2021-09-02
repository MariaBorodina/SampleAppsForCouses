package com.mb.CoffeeSpace;


import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class App {
    static ConsoleLogger logger = new ConsoleLogger();

    public App(ConsoleLogger consoleLogger)
    {
        this.logger = consoleLogger;
    }

    public static void main(String[] args)
    {
        ApplicationContext ctx = new ClassPathXmlApplicationContext("spring.xml");

        ConsoleLogger localLogger = (ConsoleLogger)ctx.getBean("eventLogger");
        localLogger.log("test spring message");


        CoffeeKind kinda1 = new CoffeeKind("First");

        logger.log(kinda1.getName() + ": id = " + kinda1.getId());

    }


}

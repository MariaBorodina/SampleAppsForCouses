package com.mb.CoffeeSpace;


import com.mb.CoffeeSpace.Intefaces.EventLogger;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class App {
    static EventLogger logger = new ConsoleLogger();

    public static void main(String[] args)
    {
        ApplicationContext ctx = new ClassPathXmlApplicationContext("spring.xml");

        EventLogger localLogger = ctx.getBean(EventLogger.class);
        localLogger.log("test spring message");


        CoffeeKind kinda1 = new CoffeeKind("First");
        logger.log(kinda1.getName() + ": id = " + kinda1.getId());

        CoffeeKind kindaBean = (CoffeeKind) ctx.getBean("coffeeKind");
        logger.log(kindaBean.getName() + ": id = " + kindaBean.getId());

    }

    public App(CoffeeKind coffeeKind, EventLogger eventLogger)
    {
        logger = eventLogger;
    }


}

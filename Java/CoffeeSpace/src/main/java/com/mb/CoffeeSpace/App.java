package com.mb.CoffeeSpace;


import com.mb.CoffeeSpace.Intefaces.EventLogger;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class App {
    static ConsoleLogger logger = new ConsoleLogger();

    public static void main(String[] args)
    {
        ApplicationContext ctx = new ClassPathXmlApplicationContext("spring.xml");

        EventLogger localLogger = (EventLogger)ctx.getBean("eventLogger");
        localLogger.log("test spring message");


        CoffeeKind kinda1 = new CoffeeKind("First");
        logger.log(kinda1.getName() + ": id = " + kinda1.getId());

        CoffeeKind kindaBean = (CoffeeKind) ctx.getBean("coffeeKind");
        logger.log(kindaBean.getName() + ": id = " + kindaBean.getId());

    }


}

package com.mb.CoffeeSpace.Services;

import com.mb.CoffeeSpace.Intefaces.EventLogger;
import com.mb.CoffeeSpace.Models.Event;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class FileLogger implements EventLogger {
    private String filename;

    public FileLogger(String filename) {
        this.filename = filename;
    }

    public void init() throws IOException {
        var file = new File(filename);
        if(! file.canWrite())
        {
            throw new IOException(String.format("Cannot write into file %s.", filename));
        }
    }


    @Override
    public void log(String message) throws IOException {
        var writer = new PrintWriter(new FileWriter(filename, true));
        writer.println(message);
        writer.close();
    }


}

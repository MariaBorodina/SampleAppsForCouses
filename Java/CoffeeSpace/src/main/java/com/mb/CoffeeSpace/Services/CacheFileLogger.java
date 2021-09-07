package com.mb.CoffeeSpace.Services;

import org.springframework.stereotype.Component;
import javax.annotation.PreDestroy;

import java.io.IOException;
import java.util.LinkedList;
import java.util.List;

@Component
public class CacheFileLogger extends FileLogger {
    private int maxCacheSize;

    private List<String> cache = new LinkedList<>();

    public CacheFileLogger(String filename, int maxCacheSize) {
        super(filename);
        this.maxCacheSize = maxCacheSize;

    }

    @Override
    public void log(String message) throws IOException {
        int cacheSize =cache.size();

        if(cacheSize < maxCacheSize) {
            cache.add(message);
        }
        if(cacheSize == maxCacheSize + 1) {
            flush();
        }

    }

    @PreDestroy
    public void flush() throws IOException {
        var builder = new StringBuilder(maxCacheSize);

        for (var str: cache) {
            builder.append(str + '\n');
        }

        if(builder.length() > 0) {
            builder.substring(0, builder.length() - 1);
            super.log(builder.toString());
        }

        cache.clear();
    }


}

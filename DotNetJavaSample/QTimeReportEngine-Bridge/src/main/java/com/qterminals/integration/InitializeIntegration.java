package com.qterminals.integration;

import com.qterminals.LaunchApp;
import lombok.extern.slf4j.Slf4j;
import org.springframework.boot.SpringApplication;
import org.springframework.context.ConfigurableApplicationContext;

@Slf4j
public class InitializeIntegration {
    private static ConfigurableApplicationContext ConfigurableApplicationContext;

    public String Message(String lang) {
        return String.format("This method is being called from Java using JNI4Net (Lang: %s)", lang);
    }

    public static void Setup(String... args){
        InitializeIntegration.ConfigurableApplicationContext = SpringApplication.run(LaunchApp.class, args);
    }

    /*public static ConfigurableApplicationContext GetConfigurableApplicationContext(){
        return ConfigurableApplicationContext;
    }*/
}

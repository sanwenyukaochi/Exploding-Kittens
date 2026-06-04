plugins {
    java
    `java-library`
}

description = "Cross-cutting middleware infrastructure"

dependencies {
    api(project(":infrastructure:middleware:kafka:kafka-config-data"))
}

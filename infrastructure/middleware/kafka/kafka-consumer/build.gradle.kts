plugins {
    java
    `java-library`
    id("io.spring.dependency-management")
}

description = "Distributed lock infrastructure"

dependencies {
    api(project(":infrastructure:middleware:kafka:kafka-config-data"))
    implementation("org.springframework.kafka:spring-kafka")
    implementation("org.apache.avro:avro")
}

plugins {
    java
    `java-library`
    id("io.spring.dependency-management")
}

description = "Distributed lock infrastructure"

dependencies {
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
    api(project(":infrastructure:middleware:kafka:kafka-config-data"))
    api(project(":infrastructure:middleware:kafka:kafka-model"))
    implementation("io.confluent:kafka-avro-serializer")
    implementation("org.springframework.kafka:spring-kafka")
    implementation("org.apache.avro:avro")
}

plugins {
    java
    id("io.spring.dependency-management")
}

repositories {
    mavenCentral()
}

dependencies {
    implementation(project(":infrastructure:kafka:kafka-config-data"))
    implementation("org.springframework.kafka:spring-kafka")
    implementation("org.apache.avro:avro")
}

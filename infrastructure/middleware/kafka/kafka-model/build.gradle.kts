plugins {
    java
    `java-library`
    id("io.spring.dependency-management")
}

description = "Distributed lock infrastructure"

dependencies {
    implementation("org.apache.avro:avro")
}

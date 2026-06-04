plugins {
    java
    `java-library`
    id("io.spring.dependency-management")
}

description = "Distributed lock infrastructure"

dependencies {
    api(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-amqp")
    implementation("org.redisson:redisson:${libs.versions.redisson.get()}")
}

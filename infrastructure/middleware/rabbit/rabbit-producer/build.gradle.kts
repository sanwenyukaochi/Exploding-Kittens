plugins {
    java
    `java-library`
    id("io.spring.dependency-management")
}

description = "Distributed lock infrastructure"

dependencies {
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
    api(project(":infrastructure:middleware:rabbit:rabbit-config-data"))
    implementation("org.springframework.amqp:spring-rabbit")
}

plugins {
    java
    `java-library`
}

description = "Transactional outbox infrastructure"

dependencies {
    api(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
}

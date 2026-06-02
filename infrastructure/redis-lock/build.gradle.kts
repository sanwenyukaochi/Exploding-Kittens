plugins {
    java
    `java-library`
}

description = "Distributed lock infrastructure"

dependencies {
    api(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-redis")
    implementation("org.redisson:redisson:${libs.versions.redisson.get()}")
}

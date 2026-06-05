plugins {
    java
    `java-library`
}

description = "Game persistence adapters"

dependencies {
    implementation(project(":game-service:game-domain:game-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

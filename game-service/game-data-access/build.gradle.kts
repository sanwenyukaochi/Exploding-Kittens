plugins {
    java
    `java-library`
}

description = "Game persistence adapters"

dependencies {
    api(project(":game-service:game-domain"))
    implementation(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

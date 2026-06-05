plugins {
    java
    `java-library`
}

description = "Settlement persistence adapters"

dependencies {
    implementation(project(":settlement-service:settlement-domain:settlement-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

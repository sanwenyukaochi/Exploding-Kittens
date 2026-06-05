plugins {
    java
    `java-library`
}

description = "User persistence adapters"

dependencies {
    implementation(project(":user-service:user-domain:user-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

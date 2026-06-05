plugins {
    java
    `java-library`
}

description = "Room persistence adapters"

dependencies {
    implementation(project(":room-service:room-domain:room-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

plugins {
    java
    `java-library`
}

description = "Room persistence adapters"

dependencies {
    api(project(":room-service:room-domain"))
    implementation(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

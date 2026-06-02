plugins {
    java
    `java-library`
}

description = "Settlement persistence adapters"

dependencies {
    api(project(":settlement-service:settlement-domain"))
    implementation(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

plugins {
    java
    `java-library`
}

description = "User persistence adapters"

dependencies {
    api(project(":user-service:user-domain"))
    implementation(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
}

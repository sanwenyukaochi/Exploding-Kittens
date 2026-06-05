plugins {
    java
    `java-library`
}
description = "User security support"

dependencies {
    implementation(project(":user-service:user-domain:user-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-security")
    implementation("io.jsonwebtoken:jjwt-api:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-impl:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-jackson:${libs.versions.jjwt.get()}")
}

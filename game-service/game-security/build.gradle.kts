plugins {
    java
    `java-library`
}

description = "Game security support"

dependencies {
    implementation(project(":game-service:game-domain:game-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-security")
    testImplementation("org.springframework.security:spring-security-test")
}

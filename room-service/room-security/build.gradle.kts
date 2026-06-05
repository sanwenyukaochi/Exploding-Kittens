plugins {
    java
    `java-library`
}

description = "Room security support"

dependencies {
    implementation(project(":room-service:room-domain:room-application-service"))
    implementation("org.springframework.boot:spring-boot-starter-security")
    testImplementation("org.springframework.security:spring-security-test")
}

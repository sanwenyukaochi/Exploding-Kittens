plugins {
    java
    `java-library`
}

description = "Room security support"

dependencies {
    api(project(":room-service:room-domain"))
    implementation(project(":common:common-web"))
    implementation("org.springframework.boot:spring-boot-starter-security")
    testImplementation("org.springframework.security:spring-security-test")
}

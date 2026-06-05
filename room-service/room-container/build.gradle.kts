plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "Room service boot application"

dependencies {
    implementation(project(":room-service:room-application"))
    implementation(project(":room-service:room-data-access"))
    implementation(project(":room-service:room-security"))
    implementation("org.springframework.boot:spring-boot-starter-actuator")
}

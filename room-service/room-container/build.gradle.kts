plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "Room service boot application"

dependencies {
    implementation(project(":common:common-web"))
    implementation(project(":infrastructure:middleware"))
    implementation(project(":infrastructure:redis-lock"))
    implementation(project(":room-service:room-domain"))
    implementation(project(":room-service:room-data-access"))
    implementation(project(":room-service:room-security"))
    implementation("org.springframework.boot:spring-boot-starter-actuator")
}

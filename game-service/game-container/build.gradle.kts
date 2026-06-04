plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "Game service boot application"

dependencies {
    implementation(project(":common:common-web"))
    implementation(project(":game-service:game-domain"))
    implementation(project(":game-service:game-data-access"))
    implementation(project(":game-service:game-realtime"))
    implementation(project(":game-service:game-security"))
    implementation("org.springframework.boot:spring-boot-starter-actuator")
}

plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "User service boot application"

dependencies {
    implementation(project(":common:common-web"))
    implementation(project(":user-service:user-domain"))
    implementation(project(":user-service:user-data-access"))
    implementation(project(":user-service:user-security"))
    implementation("org.springframework.boot:spring-boot-starter-actuator")
}

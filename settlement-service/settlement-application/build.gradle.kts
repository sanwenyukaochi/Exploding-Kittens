plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "User service boot application"

dependencies {
    implementation(project(":settlement-service:settlement-domain:settlement-application-service"))
    implementation(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-web")
    implementation("org.springframework.boot:spring-boot-starter-validation")
}

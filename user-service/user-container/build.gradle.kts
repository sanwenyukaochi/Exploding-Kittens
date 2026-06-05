plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "User service boot application"

dependencies {
    implementation(project(":user-service:user-domain:user-domain-core"))
    implementation(project(":user-service:user-domain:user-application-service"))
    implementation(project(":user-service:user-application"))
    implementation(project(":user-service:user-data-access"))
    implementation(project(":user-service:user-security"))
    implementation("org.springframework.boot:spring-boot-starter")
}

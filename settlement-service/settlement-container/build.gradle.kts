plugins {
    id("org.springframework.boot")
    id("com.gorylenko.gradle-git-properties")

    java
    `java-library`
}

description = "Settlement service boot application"

dependencies {
    implementation(project(":common:common-web"))
    implementation(project(":infrastructure:middleware"))
    implementation(project(":infrastructure:outbox"))
    implementation(project(":infrastructure:saga"))
    implementation(project(":infrastructure:id-generator"))
    implementation(project(":settlement-service:settlement-domain"))
    implementation(project(":settlement-service:settlement-data-access"))
    implementation("org.springframework.boot:spring-boot-starter-actuator")
}

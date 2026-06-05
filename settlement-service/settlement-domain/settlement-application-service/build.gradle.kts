plugins {
    java
    `java-library`
}

description = "User bounded context domain model"

dependencies {
    implementation(project(":settlement-service:settlement-domain:settlement-domain-core"))
    implementation(project(":common:common-domain"))
    implementation("org.springframework.boot:spring-boot-starter-validation")
}

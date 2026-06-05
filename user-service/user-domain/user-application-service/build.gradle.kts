plugins {
    java
    `java-library`
}

description = "User bounded context domain model"

dependencies {
    implementation(project(":user-service:user-domain:user-domain-core"))
    implementation(project(":common:common-domain"))
    implementation("org.springframework.boot:spring-boot-starter-validation")
}

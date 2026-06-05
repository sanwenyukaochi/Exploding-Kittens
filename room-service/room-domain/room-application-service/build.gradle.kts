plugins {
    java
    `java-library`
}

description = "Room bounded context domain application service"

dependencies {
    implementation(project(":room-service:room-domain:room-domain-core"))
    implementation(project(":common:common-domain"))
    implementation("org.springframework.boot:spring-boot-starter-validation")
}

plugins {
    java
    `java-library`
}
description = "User security support"

dependencies {
    api(project(":user-service:user-domain"))
    implementation(project(":common:common-web"))
    implementation("org.springframework.boot:spring-boot-starter-security")
    implementation("io.jsonwebtoken:jjwt-api:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-impl:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-jackson:${libs.versions.jjwt.get()}")
    testImplementation("org.springframework.security:spring-security-test")
}

plugins {
    java
    `java-library`
}

description = "WebSocket infrastructure support"

dependencies {
    api(project(":common:common-web"))
    implementation("org.springframework.boot:spring-boot-starter-websocket")
}

plugins {
    java
    `java-library`
}

description = "Game realtime adapters"

dependencies {
    implementation(project(":game-service:game-domain:game-application-service"))
    implementation(project(":common:common-web"))
    implementation(project(":infrastructure:websocket"))
}

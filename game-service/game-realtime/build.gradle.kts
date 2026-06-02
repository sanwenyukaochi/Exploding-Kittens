plugins {
    java
    `java-library`
}

description = "Game realtime adapters"

dependencies {
    api(project(":game-service:game-domain"))
    implementation(project(":common:common-web"))
    implementation(project(":infrastructure:websocket"))
}

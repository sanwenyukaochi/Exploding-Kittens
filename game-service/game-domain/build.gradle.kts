plugins {
    java
    `java-library`
}

description = "Game bounded context domain model"

dependencies {
    api(project(":common:common-domain"))
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
}

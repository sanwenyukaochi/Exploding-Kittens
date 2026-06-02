plugins {
    java
    `java-library`
}

description = "Game bounded context domain application service"

dependencies {
    api(project(":common:common-domain"))
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
}

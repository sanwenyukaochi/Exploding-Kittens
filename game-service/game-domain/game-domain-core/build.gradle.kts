plugins {
    java
    `java-library`
}

description = "Game bounded context domain model"

dependencies {
    implementation(project(":common:common-domain"))
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
}

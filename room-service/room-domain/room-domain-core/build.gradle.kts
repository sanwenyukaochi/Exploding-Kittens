plugins {
    java
    `java-library`
}

description = "Room bounded context domain model"

dependencies {
    implementation(project(":common:common-domain"))
}

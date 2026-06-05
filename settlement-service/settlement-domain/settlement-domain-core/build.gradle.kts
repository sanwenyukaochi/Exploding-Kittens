plugins {
    java
    `java-library`
}

description = "User bounded context domain model"

dependencies {
    implementation(project(":common:common-domain"))
}

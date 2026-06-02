plugins {
    java
    `java-library`
}

description = "Game bounded context domain model"

dependencies {
    api(project(":common:common-domain"))
}

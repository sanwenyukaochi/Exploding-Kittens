plugins {
    java
    `java-library`
}

description = "Room bounded context domain model"

dependencies {
    api(project(":common:common-domain"))
}

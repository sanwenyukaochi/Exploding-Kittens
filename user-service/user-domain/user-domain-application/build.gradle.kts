plugins {
    java
    `java-library`
}

description = "User bounded context domain model"

dependencies {
    api(project(":common:common-domain"))
}

plugins {
    java
    `java-library`
}

description = "Settlement bounded context domain model"

dependencies {
    api(project(":common:common-domain"))
}

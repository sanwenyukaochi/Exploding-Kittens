plugins {
    java
    `java-library`
}

description = "Cross-cutting middleware infrastructure"

dependencies {
    api(project(":common:common-application"))
}

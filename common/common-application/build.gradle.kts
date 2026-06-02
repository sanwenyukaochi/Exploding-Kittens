plugins {
    java
    `java-library`
}

description = "Shared application services"

dependencies {
    api(project(":common:common-domain"))
    implementation(project(":common:common-utils"))
}

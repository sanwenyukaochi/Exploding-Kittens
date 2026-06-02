plugins {
    java
    `java-library`
}

description = "Shared web layer support"

dependencies {
    api(project(":common:common-application"))
    implementation("org.springframework.boot:spring-boot-starter-web")
    implementation("org.springframework.boot:spring-boot-starter-validation")
    implementation("org.springdoc:springdoc-openapi-starter-webmvc-ui:${libs.versions.springdoc.get()}")
    implementation("org.apache.commons:commons-lang3:${libs.versions.commonsLang3.get()}")
}

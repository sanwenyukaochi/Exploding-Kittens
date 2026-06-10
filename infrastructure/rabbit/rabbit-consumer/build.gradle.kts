plugins {
    java
    id("io.spring.dependency-management")
}

repositories {
    mavenCentral()
}
dependencies {
    implementation(project(":infrastructure:rabbit:rabbit-config-data"))
    implementation("org.springframework.amqp:spring-rabbit")
}

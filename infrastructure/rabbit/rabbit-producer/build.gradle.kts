plugins {
    java
    id("io.spring.dependency-management")
}

repositories {
    mavenCentral()
}

dependencies {
    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")
    implementation(project(":infrastructure:rabbit:rabbit-config-data"))
    implementation("org.springframework.amqp:spring-rabbit")
}

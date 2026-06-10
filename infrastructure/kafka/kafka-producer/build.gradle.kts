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
    implementation(project(":infrastructure:kafka:kafka-config-data"))
    implementation(project(":infrastructure:kafka:kafka-model"))
    implementation("io.confluent:kafka-avro-serializer")
    implementation("org.springframework.kafka:spring-kafka")
    implementation("org.apache.avro:avro")
}

plugins {
    java
    id("io.spring.dependency-management")
    id("io.github.flumennigrum.gradle.avro")
}

repositories {
    mavenCentral()
}

dependencies {
    implementation("org.apache.avro:avro")
}

avro {
    source.from("src/main/avro")
    outputDir.set(layout.buildDirectory.dir("generated/source/avro/main"))
}

tasks.compileJava {
    dependsOn(tasks.named("generateAvroJava"))
}

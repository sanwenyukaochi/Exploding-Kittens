import com.diffplug.gradle.spotless.SpotlessExtension
import io.spring.gradle.dependencymanagement.dsl.DependencyManagementExtension
import org.gradle.api.plugins.JavaPluginExtension
import org.gradle.api.tasks.testing.Test
import org.springframework.boot.gradle.plugin.SpringBootPlugin
import org.springframework.boot.gradle.dsl.SpringBootExtension

plugins {
    id("org.springframework.boot") version "4.0.5" apply false
    id("io.spring.dependency-management") version "1.1.7" apply false
    id("com.gorylenko.gradle-git-properties") version "2.5.7" apply false
    id("com.diffplug.spotless") version "8.4.0" apply false
}

group = "com.kittens.exploding"
version = "0.0.1-SNAPSHOT"

allprojects {
    group = rootProject.group
    version = rootProject.version
}

subprojects {
    pluginManager.withPlugin("java") {
        apply(plugin = "com.diffplug.spotless")

        extensions.configure<JavaPluginExtension> {
            sourceCompatibility = JavaVersion.VERSION_26
            targetCompatibility = JavaVersion.VERSION_26
            toolchain {
                languageVersion.set(JavaLanguageVersion.of(26))
            }
            withSourcesJar()
        }

        dependencies {
            add("compileOnly", "org.projectlombok:lombok")
            add("annotationProcessor", "org.projectlombok:lombok")
            add("testCompileOnly", "org.projectlombok:lombok")
            add("testAnnotationProcessor", "org.projectlombok:lombok")
            add("implementation", "org.springframework.boot:spring-boot-starter-logging")
            add("testImplementation", "org.mockito:mockito-core")
        }

        tasks.withType<Test> {
            useJUnitPlatform()
        }

        tasks.named("compileJava") {
            dependsOn(tasks.named("spotlessCheck"))
        }
    }

    pluginManager.withPlugin("io.spring.dependency-management") {
        extensions.configure<DependencyManagementExtension> {
            imports {
                mavenBom(SpringBootPlugin.BOM_COORDINATES)
            }
            dependencies {
                dependency("org.springframework.kafka:spring-kafka:${property("springKafkaVersion")}")
                dependency("io.confluent:kafka-avro-serializer:${property("kafkaAvroSerializerVersion")}")
                dependency("org.apache.avro:avro:${property("avroVersion")}")
            }
        }
    }

    pluginManager.withPlugin("org.springframework.boot") {
        extensions.configure<SpringBootExtension> {
            buildInfo()
        }
    }

    pluginManager.withPlugin("com.diffplug.spotless") {
        extensions.configure<SpotlessExtension> {
            encoding("UTF-8")
            java {
                palantirJavaFormat()
                importOrder()
                removeUnusedImports()
                formatAnnotations()
                trimTrailingWhitespace()
                endWithNewline()
                toggleOffOn()
            }

            kotlin {
                ktlint()
            }

            kotlinGradle {
                ktlint()
            }
        }
    }
}

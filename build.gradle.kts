import com.diffplug.gradle.spotless.SpotlessExtension
import io.spring.gradle.dependencymanagement.dsl.DependencyManagementExtension
import org.gradle.api.JavaVersion
import org.gradle.api.plugins.JavaPluginExtension
import org.gradle.api.tasks.testing.Test
import org.gradle.jvm.toolchain.JavaLanguageVersion
import org.springframework.boot.gradle.dsl.SpringBootExtension
import org.springframework.boot.gradle.plugin.SpringBootPlugin

plugins {
    id("org.springframework.boot") version "4.0.6" apply false
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
        pluginManager.apply("io.spring.dependency-management")
        pluginManager.apply("com.diffplug.spotless")

        extensions.configure<JavaPluginExtension> {
            sourceCompatibility = JavaVersion.VERSION_26
            targetCompatibility = JavaVersion.VERSION_26
            toolchain {
                languageVersion.set(JavaLanguageVersion.of(26))
            }
            withSourcesJar()
        }

        tasks.named<Test>("test") {
            useJUnitPlatform()
        }
    }

    pluginManager.withPlugin("org.springframework.boot") {
        extensions.configure<SpringBootExtension> {
            buildInfo()
        }
    }

    pluginManager.withPlugin("io.spring.dependency-management") {
        extensions.configure<DependencyManagementExtension> {
            imports {
                mavenBom(SpringBootPlugin.BOM_COORDINATES)
            }
            dependencies {
                dependency("org.redisson:redisson:${libs.versions.redisson.get()}")
                dependency("cn.hutool:hutool-core:${libs.versions.hutool.get()}")
                dependency("org.springdoc:springdoc-openapi-starter-webmvc-ui:${libs.versions.springdoc.get()}")
                dependency("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
            }
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

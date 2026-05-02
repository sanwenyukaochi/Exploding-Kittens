import com.diffplug.gradle.spotless.SpotlessExtension
import com.gorylenko.GitPropertiesPluginExtension
import org.springframework.boot.gradle.dsl.SpringBootExtension

plugins {
    java
    id("org.springframework.boot") version "4.0.5"
    id("io.spring.dependency-management") version "1.1.7"
    id("com.gorylenko.gradle-git-properties") version "2.5.7"
    id("com.diffplug.spotless") version "8.4.0"
}

group = "com.spring.security"
version = "0.0.1-SNAPSHOT"
description = "project-security"

dependencies {
    implementation("org.springframework.boot:spring-boot-starter-data-jpa")
    implementation("org.springframework.boot:spring-boot-starter-web")
    implementation("org.springframework.boot:spring-boot-starter-validation")
    implementation("org.springframework.boot:spring-boot-starter-actuator")
    implementation("org.springframework.boot:spring-boot-starter-flyway")
    runtimeOnly("org.flywaydb:flyway-database-postgresql")

    implementation("org.springframework.boot:spring-boot-starter-data-redis")
    implementation("org.redisson:redisson:${libs.versions.redisson.get()}")
    implementation("cn.hutool:hutool-core:${libs.versions.hutool.get()}")

    implementation("org.springdoc:springdoc-openapi-starter-webmvc-ui:${libs.versions.springdoc.get()}")
    implementation("org.apache.commons:commons-lang3:${libs.versions.commonsLang3.get()}")

    implementation("io.jsonwebtoken:jjwt-api:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-impl:${libs.versions.jjwt.get()}")
    runtimeOnly("io.jsonwebtoken:jjwt-jackson:${libs.versions.jjwt.get()}")

    runtimeOnly("org.postgresql:postgresql:${libs.versions.postgresql.get()}")
    implementation("org.jspecify:jspecify:${libs.versions.jspecify.get()}")

    compileOnly("org.projectlombok:lombok")
    annotationProcessor("org.projectlombok:lombok")

    implementation("io.jsonwebtoken:jjwt-api:${libs.versions.jjwt.get()}")

    implementation("org.springframework.ai:spring-ai-starter-model-openai")
    implementation("org.springframework.ai:spring-ai-starter-model-deepseek")

    testImplementation("org.springframework.boot:spring-boot-starter-test")
    testImplementation("org.springframework.security:spring-security-test")
    testRuntimeOnly("org.junit.platform:junit-platform-launcher")
}

pluginManager.withPlugin("org.springframework.boot") {
    extensions.configure<SpringBootExtension> {
        buildInfo()
    }
}

pluginManager.withPlugin("com.gorylenko.gradle-git-properties") {
    extensions.configure<GitPropertiesPluginExtension> {
        failOnNoGitDirectory = false
        keys =
            listOf(
                "git.branch",
                "git.build.host",
                "git.build.user.email",
                "git.build.user.name",
                "git.build.version",
                "git.closest.tag.commit.count",
                "git.closest.tag.name",
                "git.commit.id",
                "git.commit.id.abbrev",
                "git.commit.id.describe",
                "git.commit.message.full",
                "git.commit.message.short",
                "git.commit.time",
                "git.commit.user.email",
                "git.commit.user.name",
                "git.dirty",
                "git.remote.origin.url",
                "git.tags",
                "git.total.commit.count",
            )
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

tasks.withType<Test> {
    useJUnitPlatform()
}

tasks.named("compileJava") {
    dependsOn(tasks.named("spotlessCheck"))
}

dependencyManagement {
    imports {
        mavenBom("org.springframework.ai:spring-ai-bom:${libs.versions.springAi.get()}")
    }
}

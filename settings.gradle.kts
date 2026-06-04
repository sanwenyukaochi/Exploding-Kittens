pluginManagement {
    repositories {
        mavenCentral()
        maven { setUrl("https://packages.confluent.io/maven/") }
        gradlePluginPortal()
        google()
    }
}

@Suppress("UnstableApiUsage")
dependencyResolutionManagement {
    repositoriesMode.set(RepositoriesMode.FAIL_ON_PROJECT_REPOS)
    repositories {
        mavenCentral()
        maven { setUrl("https://packages.confluent.io/maven/") }
        google()
    }
}

rootProject.name = "exploding kittens"

include(
    "common:common-domain",
    "common:common-application",
    "common:common-web",
    "common:common-utils",

    "infrastructure:middleware",
    "infrastructure:middleware:redis",
    "infrastructure:middleware:rabbit",
    "infrastructure:middleware:kafka",
    "infrastructure:middleware:kafka:kafka-config-data",
    "infrastructure:middleware:kafka:kafka-consumer",
    "infrastructure:middleware:kafka:kafka-model",
    "infrastructure:middleware:kafka:kafka-producer",
    "infrastructure:websocket",
    "infrastructure:outbox",
    "infrastructure:saga",
    "infrastructure:id-generator",

    "user-service:user-container",
    "user-service:user-domain",
    "user-service:user-data-access",
    "user-service:user-security",

    "room-service:room-container",
    "room-service:room-domain",
    "room-service:room-data-access",
    "room-service:room-security",

    "game-service:game-container",
    "game-service:game-domain",
    "game-service:game-domain:game-application-service",
    "game-service:game-domain:game-domain-core",
    "game-service:game-data-access",
    "game-service:game-realtime",
    "game-service:game-security",

    "settlement-service:settlement-container",
    "settlement-service:settlement-domain",
    "settlement-service:settlement-data-access"
)
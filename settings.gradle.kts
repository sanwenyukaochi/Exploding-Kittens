pluginManagement {
    repositories {
        mavenCentral()
        maven { setUrl("https://maven.aliyun.com/repository/central") }
        maven { setUrl("https://maven.aliyun.com/repository/jcenter") }
        maven { setUrl("https://maven.aliyun.com/repository/google") }
        maven { setUrl("https://maven.aliyun.com/repository/gradle-plugin") }
        maven { setUrl("https://maven.aliyun.com/repository/public") }
        maven { setUrl("https://jitpack.io") }
        gradlePluginPortal()
        google()
    }
}

@Suppress("UnstableApiUsage")
dependencyResolutionManagement {
    repositoriesMode.set(RepositoriesMode.FAIL_ON_PROJECT_REPOS)
    repositories {
        mavenCentral()
        maven { setUrl("https://maven.aliyun.com/repository/central") }
        maven { setUrl("https://maven.aliyun.com/repository/jcenter") }
        maven { setUrl("https://maven.aliyun.com/repository/google") }
        maven { setUrl("https://maven.aliyun.com/repository/gradle-plugin") }
        maven { setUrl("https://maven.aliyun.com/repository/public") }
        maven { setUrl("https://jitpack.io") }
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
    "infrastructure:websocket",
    "infrastructure:redis-lock",
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
    "game-service:game-data-access",
    "game-service:game-realtime",
    "game-service:game-security",

    "settlement-service:settlement-container",
    "settlement-service:settlement-domain",
    "settlement-service:settlement-data-access"
)
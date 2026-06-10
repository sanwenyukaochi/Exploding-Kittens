plugins {
}

repositories {
    mavenCentral()
}

subprojects {
    repositories {
        maven {
            url = uri("https://packages.confluent.io/maven/")
        }
    }
}

dependencies {
}

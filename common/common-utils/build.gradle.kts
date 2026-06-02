plugins {
    java
    `java-library`
}

description = "Shared utility components"

dependencies {
    api("org.apache.commons:commons-lang3:${libs.versions.commonsLang3.get()}")
    api("cn.hutool:hutool-core:${libs.versions.hutool.get()}")
    api("org.jspecify:jspecify:${libs.versions.jspecify.get()}")
}

rootProject.name = "exploding kittens"

include(
    "infrastructure",
    "infrastructure:kafka",
    "infrastructure:kafka:kafka-config-data",
    "infrastructure:kafka:kafka-consumer",
    "infrastructure:kafka:kafka-model",
    "infrastructure:kafka:kafka-producer",
    "infrastructure:rabbit",
    "infrastructure:rabbit:rabbit-config-data",
    "infrastructure:rabbit:rabbit-consumer",
    "infrastructure:rabbit:rabbit-producer",
    "infrastructure:redis",
)

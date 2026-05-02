package com.ledger.ai.repository;

import com.ledger.ai.entity.UserEntity;
import java.util.Optional;
import org.jspecify.annotations.NonNull;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface UserJpaRepository extends JpaRepository<@NonNull UserEntity, @NonNull Long> {

    Optional<UserEntity> findByUsername(String username);

    boolean existsByUsername(String user);
}

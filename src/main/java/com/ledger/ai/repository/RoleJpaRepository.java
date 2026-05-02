package com.ledger.ai.repository;

import com.ledger.ai.entity.RoleEntity;
import org.jspecify.annotations.NonNull;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface RoleJpaRepository extends JpaRepository<@NonNull RoleEntity, @NonNull Long> {}

package com.ledger.ai.entity;

import com.ledger.ai.enums.RoleCode;
import io.swagger.v3.oas.annotations.media.Schema;
import jakarta.persistence.*;
import java.util.HashSet;
import java.util.Set;
import lombok.Getter;
import lombok.Setter;
import lombok.experimental.Accessors;

@Getter
@Setter
@Accessors(chain = true)
@Entity
@Table(
        name = "sys_role",
        uniqueConstraints = {@UniqueConstraint(name = "uk_role_code", columnNames = "code")},
        comment = "角色表")
@Schema(title = "系统角色实体")
public class RoleEntity extends AbstractIdEntity<Long> {

    @Schema(title = "角色编码")
    @Column(comment = "角色编码", name = "code", length = 10, nullable = false)
    @Enumerated(EnumType.STRING)
    private RoleCode code;

    @ManyToMany(mappedBy = "roles")
    private Set<UserEntity> users = new HashSet<>();
}

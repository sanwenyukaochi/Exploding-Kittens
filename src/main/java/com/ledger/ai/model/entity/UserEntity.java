package com.ledger.ai.model.entity;

import com.ledger.ai.model.entity.base.AbstractAuditableEntity;
import io.swagger.v3.oas.annotations.media.Schema;
import jakarta.persistence.*;
import java.util.Set;
import lombok.Getter;
import lombok.Setter;
import lombok.experimental.Accessors;

@Getter
@Setter
@Accessors(chain = true)
@Entity
@Table(
        name = "sys_user",
        uniqueConstraints = {@UniqueConstraint(name = "uk_user_username", columnNames = "username")},
        comment = "用户表")
@Schema(title = "系统用户实体")
public class UserEntity extends AbstractAuditableEntity {

    @Schema(title = "用户名")
    @Column(comment = "用户名", name = "username", nullable = false, length = 20)
    private String username;

    @Schema(title = "密码", accessMode = Schema.AccessMode.WRITE_ONLY)
    @Column(comment = "用户密码", name = "password_hash", nullable = false, length = 120)
    private String password;

    @Schema(title = "账户是否锁定")
    @Column(comment = "账户是否未锁定（true=正常，false=锁定）", name = "account_non_locked", nullable = false)
    private Boolean accountNonLocked = true;

    @Schema(title = "账户是否过期")
    @Column(comment = "账户是否未过期（true=有效，false=过期）", name = "account_non_expired", nullable = false)
    private Boolean accountNonExpired = true;

    @Schema(title = "密码是否过期")
    @Column(comment = "密码是否未过期（true=有效，false=已过期）", name = "credentials_non_expired", nullable = false)
    private Boolean credentialsNonExpired = true;

    @Schema(title = "是否启用")
    @Column(comment = "状态（true=启用，false=禁用）", name = "enabled", nullable = false)
    private Boolean enabled = true;

    @ManyToMany(fetch = FetchType.LAZY)
    @JoinTable(
            name = "sys_user_roles",
            joinColumns = @JoinColumn(name = "user_id"),
            inverseJoinColumns = @JoinColumn(name = "role_id"))
    private Set<RoleEntity> roles;
}

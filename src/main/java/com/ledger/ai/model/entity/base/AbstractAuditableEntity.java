package com.ledger.ai.model.entity.base;

import io.swagger.v3.oas.annotations.media.Schema;
import jakarta.persistence.Column;
import jakarta.persistence.EntityListeners;
import jakarta.persistence.Id;
import jakarta.persistence.MappedSuperclass;
import lombok.AccessLevel;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import lombok.experimental.Accessors;
import org.springframework.data.annotation.CreatedBy;
import org.springframework.data.annotation.CreatedDate;
import org.springframework.data.annotation.LastModifiedBy;
import org.springframework.data.annotation.LastModifiedDate;
import org.springframework.data.jpa.domain.support.AuditingEntityListener;

@Getter
@Accessors(chain = true)
@NoArgsConstructor
@AllArgsConstructor
@MappedSuperclass
@EntityListeners(AuditingEntityListener.class)
@Schema(title = "基础信息字段")
public abstract class AbstractAuditableEntity {

    @Id
    @Schema(title = "主键ID")
    @Column(comment = "主键ID", name = "id", nullable = false)
    @Setter(AccessLevel.PUBLIC)
    private Long id;

    @CreatedBy
    @Column(comment = "创建者", name = "created_by", nullable = false, updatable = false)
    private Long createdBy;

    @CreatedDate
    @Column(comment = "创建时间", name = "created_at", nullable = false, updatable = false)
    private Long createdAt;

    @LastModifiedBy
    @Column(comment = "更新者", name = "updated_by", nullable = false)
    private Long updatedBy;

    @LastModifiedDate
    @Column(comment = "更新时间", name = "updated_at", nullable = false)
    private Long updatedAt;
}

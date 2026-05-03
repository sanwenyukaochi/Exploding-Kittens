package com.ledger.ai.entity;

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
import org.springframework.data.jpa.domain.support.AuditingEntityListener;

@Getter
@Accessors(chain = true)
@NoArgsConstructor
@AllArgsConstructor
@MappedSuperclass
@EntityListeners(AuditingEntityListener.class)
@Schema(title = "基础信息字段")
public abstract class AbstractIdEntity<ID> {

    @Id
    @Schema(title = "主键ID")
    @Column(comment = "主键ID", name = "id", nullable = false)
    @Setter(AccessLevel.PUBLIC)
    private ID id;

}

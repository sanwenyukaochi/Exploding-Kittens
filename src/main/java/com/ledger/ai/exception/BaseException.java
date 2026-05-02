package com.ledger.ai.exception;

import lombok.Getter;
import org.springframework.http.HttpStatus;

@Getter
public class BaseException extends RuntimeException {

    private HttpStatus httpStatus;

    private String code;

    private String message;

    public BaseException() {}

    public BaseException(HttpStatus httpStatus) {
        this.httpStatus = httpStatus;
    }

    public BaseException(String message, HttpStatus httpStatus) {
        super(message);
        this.httpStatus = httpStatus;
    }

    public BaseException(String code, String message, HttpStatus httpStatus) {
        super(message);
        this.code = code;
        this.message = message;
        this.httpStatus = httpStatus;
    }

    public BaseException(Throwable cause, HttpStatus httpStatus) {
        super(cause);
        this.httpStatus = httpStatus;
    }

    public BaseException(String message, Throwable cause, HttpStatus httpStatus) {
        super(message, cause);
        this.message = message;
        this.httpStatus = httpStatus;
    }

    public BaseException(String code, String message, Throwable cause, HttpStatus httpStatus) {
        super(message, cause);
        this.code = code;
        this.message = message;
        this.httpStatus = httpStatus;
    }
}

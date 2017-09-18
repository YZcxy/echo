package com.bzhang.entity;

import java.util.Date;

public class Info {
    public int id;
    public String detail;
    public Date time;

    public int getId() {
        return id;
    }

    public String getDetail() {
        return detail;
    }

    public Date getTime() {
        return time;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setDetail(String detail) {
        this.detail = detail;
    }

    public void setTime(Date time) {
        this.time = time;
    }

    @Override
    public String toString() {
        return "Info{" +
                "id=" + id +
                ", detail='" + detail + '\'' +
                ", time=" + time +
                '}';
    }
}

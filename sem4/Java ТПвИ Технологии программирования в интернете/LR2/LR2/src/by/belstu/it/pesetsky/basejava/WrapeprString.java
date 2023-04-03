package by.belstu.it.pesetsky.basejava;

import java.util.Objects;

//h

interface WrapperString {
    public void replace (char oldchar, char newchar);
}
public class WrapeprString implements WrapperString{
    private String pstr = "";

    public WrapeprString(String pstr) {
        this.pstr = pstr;
    }

    public String getPstr() {
        return pstr;
    }

    public void setPstr(String pstr) {
        this.pstr = pstr;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        WrapeprString that = (WrapeprString) o;
        return Objects.equals(pstr, that.pstr);
    }

    @Override
    public int hashCode() {
        return Objects.hash(pstr);
    }

    @Override
    public String toString() {
        return "WrapperString{" +
                "pstr='" + pstr + '\'' +
                '}';
    }

    public void replace (char oldchar, char newchar){
            pstr = pstr.replace(oldchar, newchar);
    }

}
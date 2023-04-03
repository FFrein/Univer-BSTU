package by.belstu.it.pesetsky.basejava;

import java.io.Console;
import java.util.Objects;
import java.util.Arrays;

import static java.lang.Math.log;
import static java.lang.Math.*;

public class JavaTest {
    static int sint;

    public static void main(String[] args) {
        //b
        char letter = 'a';
        int i_num = 1;
        short s_num = 2;
        byte b_num = 0;
        long l_num = 3l;
        boolean checker = false;
        boolean iferOne = false;
        boolean iferTwo = false;

        System.out.println("str + int " + letter + i_num); //str + int
        System.out.println("str + char " + letter + letter); //str + char
        System.out.println("str + double " + letter + 1.23d); // str + double

        b_num = (byte) (b_num + i_num);
        i_num = (int) (1.25d + l_num);
        l_num = i_num + 2147483647;

        System.out.println(sint);

        checker = iferOne && iferTwo;
        checker = iferOne ^ iferTwo;

        //checker = iferOne + iferTwo;

        long num1 = 9223372036854775807l;

        long num2 = 0x7fff_ffff_fffl;

        char letOne = 'a';
        char letTwo = '\u0061';
        char letThree = 97;
        System.out.println(letOne + letTwo + letThree);

        System.out.println(3.45d % 2.4d);
        System.out.println(1.0d / 0.0d);
        System.out.println(0.0d / 0.0d);

        System.out.println(log(-345));

        System.out.println(Float.intBitsToFloat(0x7F800000));
        System.out.println( Float.intBitsToFloat(0xFF800000));

        //d

        System.out.println(Math.PI);
        System.out.println(Math.E);

        System.out.println(Math.round(Math.PI));
        System.out.println(Math.round(Math.E));

        System.out.println(Math.min(Math.PI,Math.E));
        System.out.println(Math.random());//TODO указать диапозон

        //e
        Boolean boolean1 = Boolean.TRUE;

        Integer integer1 = Integer.MAX_VALUE;

        Long long1 = Long.valueOf("45");

        double dobl1 = Double.valueOf(100000000l);

        Float f1 = Float.MAX_VALUE;

        Character c1 = Character.valueOf('c');

        Short  s1 = Short.MAX_VALUE;

        System.out.println("Long.MAX_VALUE: " + Long.MAX_VALUE);
        System.out.println("Double.MAX_VALUE: " + Double.MAX_VALUE);
        System.out.println();

        int iii = 1111;
        Integer Integii = iii;
        int iii2 = Integii;

        System.out.println(iii >>> 3);
        System.out.println(iii >> 3);
        System.out.println("~iii: "+~iii);


        Integer i12 = Integer.parseInt("12");
        Number nmb = 12;
        System.out.println("Integer.toHexString: " + Integer.toHexString(i12));
        System.out.println("Integer.compare: " + Integer.compare(13, 20));
        System.out.println("Integer.toString: " + Integer.toString(10));
        System.out.println("Integer.bitCount: " + Integer.bitCount(10));

        System.out.println("isNaN: true");

        String strNum = "1232";

        byte[] byteArray = strNum.getBytes();
        System.out.println("Строку в массив байт : " + Arrays.toString(byteArray));

        String string = new String(byteArray);
        System.out.println("байты в строку : " + string);

        int convertedInt = Integer.valueOf(strNum);
        int cnvInt = Integer.parseInt(strNum);

        boolean blnstr = Boolean.valueOf(strNum);
        boolean blnstr2 = Boolean.getBoolean(strNum);

        String str2 = "1232";
        System.out.println("strNum == str2: "+strNum == str2);
        System.out.println("str2.equals(strNum): "+str2.equals(strNum));
        System.out.println("strNum.compareTo(str2): "+strNum.compareTo(str2));

        str2 = null;
        System.out.println("strNum == str2: "+strNum == str2);
        System.out.println("str2.equals(strNum): ");//str2.equals(strNum)
        System.out.println("strNum.compareTo(str2): ");//strNum.compareTo(str2)

        String strArr[] = strNum.split(" ");

        System.out.println("+strNum.split: " + strArr[0]);
        System.out.println("strNum.contains: "+strNum.contains("1"));
        System.out.println("strNum.hashCode: "+strNum.hashCode());
        System.out.println("strNum.indexOf: "+strNum.indexOf(1));
        System.out.println("strNum.length(): "+strNum.length());

        //g
        char[] [] cc1;
        char[] c2[];
        char c3[] [];
        /*
        Можно ли определить массив нулевой длины?
        Что случится, если индекс массива превысит его длину
        */

        cc1 = new char[3][];
        cc1[0] = new char[1];
        cc1[1] = new char[2];
        cc1[2] = new char[3];

        System.out.println("cc1.length: " + cc1.length + " | cc1[0].length: " + cc1[0].length);

        c2 = new char[2][2];
        c2[0][0] = '0';
        c2[0][1] = '1';
        c2[1][0] = '2';
        c2[1][1] = '3';

        c3 = new char[2][2];
        c3[0][0] = '0';
        c3[0][1] = '1';
        c3[1][0] = '2';
        c3[1][1] = '3';

        boolean ComRez = c2 == c3;
        c2 = c3;

        //https://javarush.com/groups/posts/for-each-java
        for(char[] charElem : c2){
            System.out.println(charElem);
        }
        /*выйдите преднамеренно за границы массива. Что будет получено?
        Выход ха пределы массива - ошибка*/

        WrapeprString WSElem = new WrapeprString("Stroka");

        WSElem.replace('a', 'b');
        System.out.println(WSElem.getPstr());

        WrapperString AWS = new WrapperString() {
            public String pstr = "";
            @Override
            public void replace(char oldchar, char newchar) {
                pstr = pstr.replace(oldchar, newchar);
            }
            public void delete(char newchar){
                pstr = pstr.replace(newchar, ' ');
                pstr = pstr.trim();
            }
        };
    }

    //c
    final int fi = 10;
    public final int pfi = 100;
    public static final int psfi = 1000;

}
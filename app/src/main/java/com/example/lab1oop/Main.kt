package com.example.lab1oop

fun main (){
    val instancePoint1=Point(4,8)
    val instancePoint2=Point(8,16)
    val instancePoint3=Point(40,48)
    val instanceLine=Line(instancePoint1,instancePoint2)
    val instanceTriangle=Triangle(instancePoint1,instancePoint2,instancePoint3)
    val instanceRectangle=Rectangle(instancePoint1,4,4)
    val instanceSquare=Square(instancePoint1,8)
    val instanceCircle=Circle(instancePoint1,40)
    val instanceEllipse=Ellipse(instancePoint1,48,48)
    //instanceLine.print();
    val flist=FiguresList(arrayOf(instanceLine,
        instanceTriangle,
        instanceSquare,
        instanceRectangle,
        instanceEllipse,
        instanceCircle))
    flist.printList();
}
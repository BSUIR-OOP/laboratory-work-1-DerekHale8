package com.example.lab1oop

class Circle(private val A:Point,private val Radius:Int):Figure(){
    override fun print(){
        println("Circle:((${A.xPos},${A.yPos}),$Radius)")
    }
}
package com.example.lab1oop

class Square(private val A:Point,private val Length:Int):Figure() {
    override fun print(){
        println("Square:((${A.xPos},${A.yPos}),$Length)")
    }
}
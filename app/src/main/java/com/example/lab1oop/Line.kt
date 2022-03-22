package com.example.lab1oop

class Line(private val A:Point,private val B:Point): Figure() {
    override fun print() {
        println("Line:((${A.xPos},${A.yPos}),(${B.xPos},${B.yPos}))");
    }
}
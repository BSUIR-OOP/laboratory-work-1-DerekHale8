package com.example.lab1oop

class Triangle(private val A:Point,private val B:Point,private val C:Point):Figure() {
    override fun print() {
        println("Triangle:((${A.xPos},${A.yPos}),(${B.xPos},${B.yPos}),(${C.xPos},${C.yPos}))");
    }
}
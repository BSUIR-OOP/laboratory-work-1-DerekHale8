package com.example.lab1oop

class Ellipse(private val A:Point,private val L:Int,private val T:Int):Figure() {
    override fun print(){
        println("Ellipse:((${A.xPos},${A.yPos}),$L,$T)")
    }
}
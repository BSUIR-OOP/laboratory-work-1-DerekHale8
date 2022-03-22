package com.example.lab1oop

class Rectangle(private val A:Point,private val Width:Int,private val Height:Int):Figure() {
    override fun print(){
        println("Rectangle:((${A.xPos},${A.yPos}),$Width,$Height)")
    }
}
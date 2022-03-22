package com.example.lab1oop

class FiguresList(var figureMassive: Array<Figure> = arrayOf<Figure>()) {
    private var figures= arrayListOf<Figure>();
    init{
        for (i in 0..figureMassive.size-1){
            figures.add(figureMassive[i])
        }
    }
    fun printList(){
        figures.forEach{it.print()}
    }
/*class FiguresList2{
    private var figures= arrayListOf<Figure>();
    constructor(figureMassive: Array<Figure> = arrayOf<Figure>()){
        for (i in 0..figureMassive.size-1){
            figures.add(figureMassive[i])
        }
    }
    fun printList(){
        figures.forEach{it.print()}
    }
}*/

}
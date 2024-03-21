using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Runtime.InteropServices;

class Computer{

    string Color; 
    string OS;
    string CPU;
    string GPU;
    int RAM;
    string Brand;    

    public Computer(){}

    public Computer(string Color, string OS, string CPU, string GPU, int RAM, string Brand){

        this.Color = Color;
        this.OS = OS;
        this.CPU = CPU;
        this.GPU = GPU;
        this.RAM = RAM;
        this.Brand = Brand;
    }

    public Computer(string Color, string OS){
        this.Color = Color;
        this.OS = OS;
    }


//Get is going to allow Main to access the value of the instance object variable, that were defined in the Main through the constrctor :)
    public string GetColor(){
        return Color;
    }

    public string GetOS(){
        return OS;
    }

    public string GetCPU(){
        return CPU;
    }

    public string GetGPU(){
        return GPU;
    }

    public int GetRAM(){
        return RAM;
    }

    public string GetBrand(){
        return Brand;
    }

// The Set Method is going to allow the user to set the specific paramether to save the valeu given to the respective instance value of the object. :)
    public void SetColor(string Color){
        this.Color = Color;
    }

    public void SetOS(string OS){
        this.OS = OS;
    }

    public void SetCPU(string CPU){
        this.CPU = CPU;
    }

    public void SetGPU(string GPU){
        this.GPU = GPU;
    }

    public void SetRAM(int RAM){
        this.RAM = RAM;
    }

    public void SetBrand(string Brand){
        this.Brand = Brand;
    }

    public string ToString(){
        return Color + "\n" + GPU + "\n" + CPU + "\n" + OS + "\n" + RAM + "\n" + Brand;
    }



}